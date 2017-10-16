using SAESP.Gestao.Application;
using SAESP.Gestao.Infra.Data.Transactions;
using SAESP.Gestao.SharedKernel.DomainEvents;
using SAESP.Gestao.SharedKernel.DomainNotification.Event;
using SAESP.Gestao.Usuario.Application.Interfaces;
using SAESP.Gestao.Usuario.Domain.DomainEvent.Handlers;
using SAESP.Gestao.Usuario.Domain.DomainEvent.Inputs;

namespace SAESP.Gestao.Usuario.Application.ApplicationServices
{
    public class UsuarioApplication : BaseApplicationService,  IUsuarioApplication
    {
        private readonly UsuarioServiceHandler _handler;

        public UsuarioApplication(IUow uow, IHandler<DomainNotification> notifications, UsuarioServiceHandler handler)
            : base(uow, notifications)
        {
            this._handler = handler;
        }

        public void RegistrarUsuario(UsuarioRegisterCommand command)
        {
            this._handler.Handle(command);

            if (Commit())
            {
                // Reações após o evento de domínio ocorrer com sucesso...
                // Ex: Enviar email, etc ... 
            }
        }
    }
}