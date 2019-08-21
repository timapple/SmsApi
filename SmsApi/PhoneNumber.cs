using System;

namespace SmsApi
{
    public sealed class PhoneNumber
    {
        public const string INFORMAL_PREFIX = "0";
        public const string FORMAL_PREFIX = "+63";
        public const string SPACE = " ";
        public const int FIXED_LENGTH_WITH_INFORMAL_PREFIX = 11;
        public const int FIXED_LENGTH_WITH_FORMAL_PREFIX = 13;
        public const int FIXED_LENGTH_WITHOUT_PREFIX = 10;
        public const int FIXED_LENGTH_NETWORK_PROVIDER = 4;

        public static bool Validate(string value, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                errorMessage = "Phone number cannot be null or white space!";
                return false;
            }

            if (value.Contains(SPACE))
            {
                errorMessage = "Phone number contains space!";
                return false;
            }

            if (value.StartsWith(INFORMAL_PREFIX) && value.Length != FIXED_LENGTH_WITH_INFORMAL_PREFIX)
            {
                errorMessage = "Phone number is invalid";
                return false;
            }

            if (value.StartsWith(FORMAL_PREFIX) && value.Length != FIXED_LENGTH_WITH_FORMAL_PREFIX)
            {
                errorMessage = "Phone number invalid!";
                return false;
            }

            if (value.Length != FIXED_LENGTH_WITHOUT_PREFIX || value.Length != FIXED_LENGTH_NETWORK_PROVIDER)
            {
                errorMessage = "Phone number is invalid!";
                return false;
            }

            errorMessage = null;
            return true;
        }

        public static bool TryParse(string value, out PhoneNumber phoneNumber)
        {
            try
            {
                phoneNumber = new PhoneNumber(value);
                return true;
            }
            catch (ArgumentException)
            {
                phoneNumber = null;
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public PhoneNumber(string value)
        {
            if (Validate(value, out string errorMessage))
            {
                throw new ArgumentException(errorMessage);
            }

            if (value.Length == FIXED_LENGTH_WITH_FORMAL_PREFIX)
            {
                value = value.Replace(FORMAL_PREFIX, INFORMAL_PREFIX);
            }
            else if (value.Length == FIXED_LENGTH_WITHOUT_PREFIX)
            {
                value = $"{INFORMAL_PREFIX}{value}";
            }

            Value = value;
        }

        public string Value { get; }

        public static implicit operator PhoneNumber(string value)
        {
            return new PhoneNumber(value);
        }

        public static implicit operator string(PhoneNumber phoneNumber)
        {
            return phoneNumber.Value;
        }
    }
}
