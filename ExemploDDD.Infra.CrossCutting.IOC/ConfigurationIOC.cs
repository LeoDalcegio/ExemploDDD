using ExemploDDD.Domain.IApplication;
using ExemploDDD.Application;
using ExemploDDD.Infra.Repository;
using ExemploDDD.Domain.IRepository;
using ExemploDDD.Infra.CrossCutting.Adapter.Map;
using ExemploDDD.Infra.CrossCutting.Adapter.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace ExemploDDD.Infra.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(IServiceCollection services)
        {
            //Aplication
            services.AddScoped<IProdutoApplication, ProdutoApplication>();
            services.AddScoped<ICategoriaApplication, CategoriaApplication>();
            
            //Infra
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();

            //Mapper
            services.AddScoped<ICategoriaMapper, CategoriaMapper>();
            services.AddScoped<IProdutoMapper, ProdutoMapper>();
        }
    }
}
