using System.Collections.Generic;

namespace SmsApi
{
    public sealed class Sim
    {
        public Sim(int port, string networkName, IEnumerable<string> attributes)
        {
            Port = port;
            NetworkName = networkName;
            Attributes = attributes;
        }

        public int Port { get; }
        public string NetworkName { get; }
        public IEnumerable<string> Attributes { get; }

        public static bool operator ==(Sim left, Sim right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Sim left, Sim right)
        {
            return !(left == right);
        }

        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (GetType() != obj.GetType()) return false;

            if (obj is Sim value)
            {
                return (Equals(Port, default(int)) && Equals(value.Port, default(int))) ? false : Equals(Port, value.Port);
            }
            else
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return Port.GetHashCode();
        }

        public override string ToString()
        {
            return $"Port {Port}";
        }
    }
}
