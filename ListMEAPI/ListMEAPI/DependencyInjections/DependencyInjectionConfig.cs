using ListMEAPI.Interfaces.Repositorios;
using ListMEAPI.Interfaces.Servicos;
using ListMEAPI.Models;
using ListMEAPI.Repositories;
using ListMEAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.DependencyInjections
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveApiDependencies(this IServiceCollection services)
        {
            services.AddDbContext<ListMEContext>(opt => opt.UseInMemoryDatabase("ListME"));

            services.AddTransient<IUsuarioService, UsuarioService>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<IResidenciaService, ResidenciaService>();
            services.AddTransient<IResidenciaRepository, ResidenciaRepository>();

            return services;
        }
        }

    }

