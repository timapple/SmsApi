using AsterNET.Manager;
using AsterNET.Manager.Event;

namespace SmsApi
{
    public sealed class ReceivedSmsEvent : ManagerEvent
    {
        public ReceivedSmsEvent(ManagerConnection source) : base(source)
        {
        }

        public string Id { get; set; }
        public string GsmSpan { get; set; }
        public string Sender { get; set; }
        public string Recvtime { get; set; }
        public string Index { get; set; }
        public string Total { get; set; }
        public string Smsc { get; set; }
        public string Content { get; set; }
    }
}
