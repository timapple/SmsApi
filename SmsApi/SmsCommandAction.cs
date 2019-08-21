using AsterNET.Manager.Action;
using System;

namespace SmsApi
{
    public sealed class SmsCommandAction : ManagerAction
    {
        public SmsCommandAction(string command)
        {
            if (string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException("Command cannot be null or white space!");
            }

            Command = command;
        }

        public override string Action { get; } = "SmsCommand";
        public string Command { get; set; }
    }
}
