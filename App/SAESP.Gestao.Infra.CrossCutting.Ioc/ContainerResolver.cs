using Microsoft.Extensions.DependencyInjection;

namespace SAESP.Gestao.Infra.CrossCutting.Ioc
{
    public static class ContainerResolver
    {
        public static void Register(IServiceCollection services)
        {
            // Invocar os demais registradores ... 
            // Separados por "módulos"
        }

    }
}