using SAESP.Gestao.SharedKernel.DomainEvents;
using SAESP.Gestao.SharedKernel.DomainEvents.Container;

namespace SAESP.Gestao.SharedKernel
{
    public static class DomainEvent
    {
        public static IContainer Container { get; set; }

        public static void Raise<T>(T evento) where T : IDomainEvent
        {
            ((IHandler<T>)Container.GetService(typeof(IHandler<T>))).Handle(evento);
        }
    }
}