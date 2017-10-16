using SAESP.Gestao.SharedKernel.DomainEvents;
using SAESP.Gestao.Usuario.Domain.DomainEvent.Inputs;

namespace SAESP.Gestao.Usuario.Domain.DomainEvent.Handlers
{
    public class UsuarioServiceHandler : IHandler<UsuarioRegisterCommand>
    {
        public void Handle(UsuarioRegisterCommand handle)
        {
            //TODO: Implementar fluxo de registro de usuários
        }
    }
}