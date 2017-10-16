namespace SAESP.Gestao.SharedKernel.DomainEvents
{
    public interface IHandler<T> where T : IDomainEvent
    {
        void Handle(T handle);
    }
}