using System;
using System.Collections.Generic;
using System.Text;

namespace SAESP.Gestao.SharedKernel.DomainEvents.Container
{
    public interface IContainer
    {
        T GetService<T>();

        object GetService(Type serviceType);

        IEnumerable<T> GetServices<T>();

        IEnumerable<object> GetServices(Type serviceType);
    }
}