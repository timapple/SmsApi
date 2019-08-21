using AsterNET.Manager;
using AsterNET.Manager.Event;

namespace SmsApi
{
    public sealed class UpdateSmsSendEvent : ManagerEvent
    {
        public UpdateSmsSendEvent(ManagerConnection source) : base(source)
        {
        }

        public string Id { get; set; }
        public string Smsc { get; set; }
        public string Status { get; set; }
    }
}
