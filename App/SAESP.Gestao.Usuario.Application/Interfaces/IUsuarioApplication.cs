using SAESP.Gestao.Usuario.Domain.DomainEvent.Inputs;

namespace SAESP.Gestao.Usuario.Application.Interfaces
{
    public interface IUsuarioApplication
    {
        void RegistrarUsuario(UsuarioRegisterCommand command);
    }
}