using System;

namespace SmsApi
{
    public sealed class ReceiveObject
    {
        public ReceiveObject(string id, int simPort, PhoneNumber sender, DateTime receivedDate, string content)
        {
            Id = id;
            SimPort = simPort;
            Sender = sender;
            ReceivedDate = receivedDate;
            Content = content;
        }

        public string Id { get; }
        public int Index { get; set; }
        public int TotalMessage { get; set; }
        public PhoneNumber Sender { get; }
        public DateTime ReceivedDate { get; }
        public string Content { get; }
        public int SimPort { get; }

        public static bool operator ==(ReceiveObject left, ReceiveObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(ReceiveObject left, ReceiveObject right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is ReceiveObject value)
            {
                return (Equals(Id, default(Guid)) && Equals(value.Id, default(Guid))) ? false : Equals(Id, value.Id);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}
