using System;
using System.Collections.Generic;
using SAESP.Gestao.SharedKernel.DomainEvents.Container;
using Microsoft.Extensions.DependencyInjection;

namespace SAESP.Gestao.Infra.CrossCutting.Ioc.SharedKernel
{
    public class DomainEventsContainer : IContainer
    {
        private readonly IServiceProvider _provider;

        public DomainEventsContainer(IServiceCollection services)
        {
            _provider = services.BuildServiceProvider();
        }

        public T GetService<T>()
        {
            return (T) this._provider.GetServices( typeof(T) );
        }

        public object GetService(Type serviceType)
        {
            return this._provider.GetService(serviceType);
        }

        public IEnumerable<T> GetServices<T>()
        {
            return (IEnumerable<T>) this._provider.GetServices( typeof(T) );
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return this._provider.GetServices(serviceType);
        }
    }
}