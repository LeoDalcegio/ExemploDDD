using Microsoft.Extensions.DependencyInjection;

namespace ExemploDDD.Infra.CrossCutting.IOC
{
    public static class ModuleIOC
    {
        public static void Load(IServiceCollection services)
        {
            ConfigurationIOC.Load(services);
        }
    }
}
