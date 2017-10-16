using SAESP.Gestao.SharedKernel.DomainEvents;

namespace SAESP.Gestao.Usuario.Domain.DomainEvent.Inputs
{
    public class UsuarioRegisterCommand : IDomainEvent
    {
        // Propriedades (APENAS GET's e SET's), sem lógica alguma.

        // Este objeto é recebido na requisição da API (Parâmetro da Action)...
        // ... evitando assim que façamos uso de AutoMapper e bibliotecas que usam Reflexão, exonerando a performance.
    }
}