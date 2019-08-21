using System;

namespace SmsApi
{
    public sealed class SentObjectUpdate
    {
        public SentObjectUpdate(Guid id, bool status)
        {
            Id = id;
            Status = status;
        }

        public Guid Id { get; }
        public bool Status { get; }

        public static bool operator ==(SentObjectUpdate left, SentObjectUpdate right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SentObjectUpdate left, SentObjectUpdate right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is SentObjectUpdate value)
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
