using System.Collections.Generic;
using SAESP.Gestao.SharedKernel.DomainNotification.Event;
using SAESP.Gestao.SharedKernel.DomainEvents;

namespace SAESP.Gestao.SharedKernel.DomainNotification.Handler
{
    public class DomainNotificationHandler : IHandler<Event.DomainNotification>
    {
        private List<Event.DomainNotification> _notifications = new List<Event.DomainNotification>();

        private List<Event.DomainNotification> GetValue()
        {
            return this._notifications;
        }

        public void Handle(Event.DomainNotification handle)
        {
            this._notifications.Add(handle);
        }

        public bool HasNotifications()
        {
            return (this.GetValue().Count > 0);
        }

        public IEnumerable<Event.DomainNotification> Notify()
        {
            return this.GetValue();
        }

        public void Dispose()
        {
            this._notifications = new List<Event.DomainNotification>();
        }
    }
}