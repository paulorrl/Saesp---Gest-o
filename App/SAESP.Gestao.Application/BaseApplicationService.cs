using SAESP.Gestao.Infra.Data.Transactions;
using SAESP.Gestao.SharedKernel;
using SAESP.Gestao.SharedKernel.DomainEvents;
using SAESP.Gestao.SharedKernel.DomainNotification.Event;
using SAESP.Gestao.SharedKernel.DomainNotification.Handler;

namespace SAESP.Gestao.Application
{
    public class BaseApplicationService
    {
        private readonly DomainNotificationHandler _notifications;
        private readonly IUow _uow;

        public BaseApplicationService(IUow uow, IHandler<DomainNotification> notifications)
        {
            this._uow = uow;
            this._notifications = (DomainNotificationHandler) notifications;
        }

        public bool HasNotification()
        {
            return _notifications.HasNotifications();
        }

        public bool Commit()
        {
            if (HasNotification()) return false;

            _uow.Commit();
            return true;
        }

        public void Rollback(string message)
        {
            DomainEvent.Raise<DomainNotification>(new DomainNotification("BusinessError", message));
            _uow.Rollback();
        }
    }
}