using AsterNET.Manager;
using AsterNET.Manager.Event;
using AsterNET.Manager.Response;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace SmsApi
{
    public class SmsApiClient : IDisposable
    {
        public delegate void ExceptionCatchedEventHandler(object sender, Exception exception);
        public delegate void ConnectionEventHandler(object sender);
        public delegate void MessageSentEventHandler(object sender, SendObject sendObject);
        public delegate void SentMessageUpdatedEventHandler(object sender, SentObjectUpdate sentObjectUpdate);
        public delegate void MessageReceivedEventHandler(object sender, ReceiveObject receiveObject);

        public const int MAX_ALLOWED_PORT = 65535;
        private const string COMMAND_SEND_SMS_PREFIX = "gsm send sms";

        private readonly Dictionary<string, string[]> _messageCache = new Dictionary<string, string[]>();
        private readonly Dictionary<int, string[]> _simPortAllowedNumberPrefixes = new Dictionary<int, string[]>();

        public SmsApiClient(string host, int port, string username, string password)
        {
            if (string.IsNullOrWhiteSpace(host))
            {
                throw new ArgumentException("Host is required!");
            }

            if (Uri.CheckHostName(host) != UriHostNameType.IPv4)
            {
                throw new ArgumentException("Unsupported host type!");
            }

            if (port < 0 || port > MAX_ALLOWED_PORT)
            {
                throw new ArgumentException("Invalid port!");
            }

            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username is required!");
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password is required!");
            }

            _managerConnection = new ManagerConnection(host, port, username, password)
            {
                FireAllEvents = true
            };

            SimPortIncremented = true;
            ResendEnabled = true;
        }

        private readonly ManagerConnection _managerConnection;
        private readonly object _roundRobinSimsLock = new object();

        public bool SimPortIncremented { get; set; }
        public bool ResendEnabled { get; set; }
        private Sim[] RoundRobinSims { get; set; }
        private int CurrentRoundRobinSimIndex { get; set; }

        public event ExceptionCatchedEventHandler ExceptionCatched;
        public event ConnectionEventHandler Connected;
        public event ConnectionEventHandler Disconnected;
        public event MessageSentEventHandler MessageSent;
        public event SentMessageUpdatedEventHandler SentMessageUpdated;
        public event MessageReceivedEventHandler MessageReceived;

        protected virtual void OnExceptionCatched(Exception exception)
        {
            ExceptionCatched?.Invoke(this, exception);
        }

        protected virtual void OnConnected()
        {
            Connected?.Invoke(this);
        }

        protected virtual void OnDisconnected()
        {
            Disconnected?.Invoke(this);
        }

        protected virtual void OnMessageSent(SendObject sendObject)
        {
            MessageSent?.Invoke(this, sendObject);
        }

        protected virtual void OnSentMessageUpdated(SentObjectUpdate sentObjectUpdate)
        {
            SentMessageUpdated?.Invoke(this, sentObjectUpdate);
        }

        protected virtual void OnMessageReceived(ReceiveObject receiveObject)
        {
            MessageReceived?.Invoke(this, receiveObject);
        }

        public void Open()
        {
            try
            {
                RegisterEvents();
                _managerConnection.Login();
            }
            catch (Exception ex)
            {
                OnExceptionCatched(ex);
            }
        }

        public void Close()
        {
            UnregisterEvents();
            _managerConnection.Logoff();
        }

        private void RegisterEvents()
        {
            _managerConnection.RegisterUserEventClass(typeof(UpdateSmsSendEvent));
            _managerConnection.RegisterUserEventClass(typeof(ReceivedSmsEvent));
            _managerConnection.ConnectionState += _managerConnection_ConnectionState;
            _managerConnection.UnhandledEvent += _managerConnection_UnhandledEvent;
            _managerConnection.Status += _managerConnection_Status;
        }

        private void _managerConnection_Status(object sender, StatusEvent e)
        {
            Debug.WriteLine(e);
        }

        private void UnregisterEvents()
        {
            _managerConnection.ConnectionState -= _managerConnection_ConnectionState;
            _managerConnection.UnhandledEvent -= _managerConnection_UnhandledEvent;
            _managerConnection.Status -= _managerConnection_Status;
        }

        private void _managerConnection_ConnectionState(object sender, ConnectionStateEvent e)
        {
            if (_managerConnection.IsConnected())
            {
                Connected?.Invoke(this);
            }
            else
            {
                Disconnected?.Invoke(this);
            }
        }

        private void _managerConnection_UnhandledEvent(object sender, ManagerEvent e)
        {
            var id = default(Guid);
            
            switch (e)
            {
                case UpdateSmsSendEvent updateSmsSendEvent:
                    Guid.TryParse(updateSmsSendEvent.Id, out id);

                    var status = updateSmsSendEvent.Status == "1";

                    OnSentMessageUpdated(new SentObjectUpdate(id, status));
                    break;
                case ReceivedSmsEvent receivedSmsEvent:
                    DateTime.TryParse(receivedSmsEvent.Recvtime, out DateTime receivedDate);
                    int.TryParse(receivedSmsEvent.Index, out int index);
                    int.TryParse(receivedSmsEvent.Total, out int total);

                    var receiveId = receivedSmsEvent.Id;
                    var simPort = int.Parse(receivedSmsEvent.GsmSpan) - (SimPortIncremented ? 1 : 0);
                    var smsSender = receivedSmsEvent.Sender;
                    var content = HttpUtility.UrlDecode(receivedSmsEvent.Content);

                    if (string.IsNullOrWhiteSpace(receiveId))
                    {
                        OnMessageReceived(new ReceiveObject(receiveId, simPort, smsSender, receivedDate, content));
                    }
                    else
                    {
                        lock (_messageCache)
                        {
                            if (!_messageCache.ContainsKey(receiveId))
                            {
                                _messageCache.Add(receiveId, new string[total]);
                            }

                            _messageCache[receiveId][index - 1] = content;

                            if (index == total)
                            {
                                var concatenatedContent = string.Join(string.Empty, _messageCache[receiveId]);
                                _messageCache.Remove(receiveId);
                                OnMessageReceived(new ReceiveObject(receiveId, simPort, smsSender, receivedDate, concatenatedContent));
                            }
                        }
                    }
                    break;

                default:
                    Debug.WriteLine(e);
                    break;
            }
        }

        public void Send(SendObject sendObject, int simPort)
        {
            if (simPort <= 0)
            {
                throw new ArgumentException("Invalid sim port!");
            }

            if (sendObject == null)
            {
                throw new ArgumentException("Invalid send object!");
            }

            if (IsAllowedSimPort(simPort, sendObject.Recipient))
            {
                var validSimPort = simPort + (SimPortIncremented ? 1 : 0);
                var validId = sendObject.Id;
                var validDestination = sendObject.Recipient.Value;
                var validContent = HttpUtility.UrlEncode(sendObject.Content);
                var command = $"{COMMAND_SEND_SMS_PREFIX} {validSimPort} {validDestination} {validContent} {validId}";
                _managerConnection.SendAction(new SmsCommandAction(command));
                OnMessageSent(sendObject);
            }
            else
            {
                OnSentMessageUpdated(new SentObjectUpdate(sendObject.Id, false));
            }
        }

        public void Send(SendObject sendObject)
        {
            //lock (_roundRobinSimsLock)
            //{
            //    TryGetRoundRobinSims();

            //    if (RoundRobinSims != null && RoundRobinSims.Any())
            //    {
            //        if (CurrentRoundRobinSimIndex >= RoundRobinSims.Length)
            //        {
            //            CurrentRoundRobinSimIndex = 0;
            //        }

            //        Send(sendObject, RoundRobinSims[CurrentRoundRobinSimIndex++].Port);
            //    }
            //}

            TryGetRoundRobinSims();

            if (RoundRobinSims != null && RoundRobinSims.Any())
            {
                if (CurrentRoundRobinSimIndex >= RoundRobinSims.Length)
                {
                    CurrentRoundRobinSimIndex = 0;
                }

                Send(sendObject, RoundRobinSims[CurrentRoundRobinSimIndex++].Port);
            }
        }

        private void TryGetRoundRobinSims()
        {
            if (RoundRobinSims == null)
            {
                var availableSims = GetAvailableSims();

                if (availableSims != null && availableSims.Any())
                {
                    RoundRobinSims = availableSims.ToArray();
                }
            }
        }

        public IEnumerable<Sim> GetAvailableSims()
        {
            try
            {
                var response = _managerConnection.SendAction(new SmsCommandAction("gsm show spans"));

                if (response is CommandResponse commandResponse)
                {
                    var result = new List<Sim>();

                    var responseResult = commandResponse.Result.ToArray();

                    foreach (var item in responseResult)
                    {
                        var chunks = item.Split(':');
                        var firstChunk = chunks[0];

                        if (chunks.Length == 2)
                        {
                            var port = GetSimPort(chunks[0]);
                            var secondChunks = chunks[1];
                            var attributes = secondChunks.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
                            var sim = new Sim(port - 1, GetSimNetworkName(port), attributes);

                            if (sim.Attributes.Contains(" Up"))
                            {
                                result.Add(sim);
                            }
                        }
                    }

                    return result;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                return null;
                //OnExceptionCatched(ex);
            }
        }

        private int GetSimPort(string raw)
        {
            return int.Parse(raw.Replace("GSM span", string.Empty));
        }

        private string GetSimNetworkName(int port)
        {
            //try
            //{
            //    _managerConnection.SendAction(new SmsCommandAction("gsm show spans"));
            //    var response = _managerConnection.SendAction(new SmsCommandAction($"gsm show span {port}"));

            //    if (response is CommandResponse commandResponse)
            //    {
            //        return commandResponse.Result[5];
            //    }
            //    else
            //    {
            //        return "Network Unavailable";
            //    }
            //}
            //catch (Exception ex)
            //{
                return "Network Unavailable";
            //}
        }

        private bool IsAllowedSimPort(int simPort, PhoneNumber phoneNumber)
        {
            if (_simPortAllowedNumberPrefixes.TryGetValue(simPort, out string[] prefixes) && prefixes != null && prefixes.Any())
            {
                var prefix = phoneNumber.Value.Substring(0, 4);
                return prefixes.Contains(prefix);
            }
            else
            {
                return true;
            }
        }

        public void SetSimAllowedPhoneNumberPrefixes(int simPort, string[] phoneNumberPrefixes)
        {
            if (simPort >= 0)
            {
                if (_simPortAllowedNumberPrefixes.ContainsKey(simPort))
                {
                    _simPortAllowedNumberPrefixes[simPort] = phoneNumberPrefixes;
                }
                else
                {
                    _simPortAllowedNumberPrefixes.Add(simPort, phoneNumberPrefixes);
                }
            }
        }

        public void Dispose()
        {
            UnregisterEvents();
            _managerConnection.Logoff();
        }
    }
}
