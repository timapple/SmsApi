using System;

namespace SmsApi
{
    public sealed class SendObject
    {
        public const int MAX_CONTENT_LENGTH = 1024;

        public SendObject(Guid id, PhoneNumber recipient, string content)
        {
            Id = id;

            if (string.IsNullOrWhiteSpace(content))
            {
                throw new ArgumentException("Content is required!");
            }

            if (content.Length > MAX_CONTENT_LENGTH)
            {
                throw new ArgumentException($"Content should not exceed {MAX_CONTENT_LENGTH} characters!");
            }

            Recipient = recipient ?? throw new ArgumentException("Recipient is required!");
            Content = content;
        }

        public SendObject(PhoneNumber recipient, string content) : this(Guid.NewGuid(), recipient, content)
        {
        }

        public Guid Id { get; }
        public PhoneNumber Recipient { get; }
        public string Content { get; }
        internal int SendRetry { get; set; }

        public static bool operator ==(SendObject left, SendObject right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(SendObject left, SendObject right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is SendObject value)
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
