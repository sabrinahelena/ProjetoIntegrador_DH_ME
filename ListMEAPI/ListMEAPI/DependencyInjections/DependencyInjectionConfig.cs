using ListMEAPI.Interfaces.Repositorios.Contato;
using ListMEAPI.Interfaces.Repositorios.Estoque;
using ListMEAPI.Interfaces.Repositorios.Lista_de_compras;
using ListMEAPI.Interfaces.Repositorios.Login;
using ListMEAPI.Interfaces.Repositorios.Produtos;
using ListMEAPI.Interfaces.Repositorios.Residencia;
using ListMEAPI.Interfaces.Repositorios.Usuario;
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

            services.AddTransient<IContatoRepository, ContatoRepository>();
            services.AddTransient<IContatoService, ContatoService>();

            services.AddTransient<IAcessoRepository, AcessoRepository>();
            services.AddTransient<IAcessoService, AcessoService>();

            services.AddTransient<IEstoqueRepository, EstoqueRepository>();
            services.AddTransient<IEstoqueService, EstoqueService>();

            services.AddTransient<IProdutosRepository, ProdutosRepository>();
            services.AddTransient<IProdutosService, ProdutosService>();

            services.AddTransient<IListaDeComprasRepository, ListaDeComprasRepository>();
            services.AddTransient<IListaDeComprasService, ListaDeComprasService>();

            services.AddTransient<ValidacaoRepository>();

            return services;
        }
        }

    }

