using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Models
{
    public class ListMEContext : DbContext
    {
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<EstoqueModel> Estoque { get; set; }
        public DbSet<ProdutosModel> Produtos { get; set; }
        public DbSet<ListaComprasModel> ListaCompras { get; set; }
        public DbSet<ResidenciaModel> Residencias { get; set; }
        public DbSet<RelacionarUsuario> RelacaoUsuario { get; set; }

        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.Entity<UsuarioModel>(TabelaUsuario =>
            {
                TabelaUsuario.HasKey(Coluna => Coluna.Id_Usuario);
                TabelaUsuario.ToTable("Usuarios");
            });
            Modelagem.Entity<EstoqueModel>(TabelaEstoque =>
            {
                TabelaEstoque.HasKey(Coluna => Coluna.Id_Estoque);
                TabelaEstoque.ToTable("Estoque");
            });
            Modelagem.Entity<ProdutosModel>(TabelaProduto =>
            {
                TabelaProduto.HasKey(Coluna => Coluna.Id_Produtos);
                TabelaProduto.ToTable("Produtos");
            });
            Modelagem.Entity<ResidenciaModel>(TabelaResidencia =>
            {
                TabelaResidencia.HasKey(Coluna => Coluna.Id_Residencias);
                TabelaResidencia.ToTable("Residencias");
            });
            Modelagem.Entity<ListaComprasModel>(TabelaListaCompras =>
            {
                TabelaListaCompras.HasKey(Coluna => Coluna.Id_ListaDeCompras);
                TabelaListaCompras.ToTable("Lista de compras");
            });
            Modelagem.Entity<RelacionarUsuario>(TabelaRelacaoUsuario =>
            {
                TabelaRelacaoUsuario.HasKey(Coluna => Coluna.Id_Relacionamento);
                TabelaRelacaoUsuario.ToTable("Relacao Usuario");
            });



        }


        protected override void OnConfiguring(DbContextOptionsBuilder Configuracao)
        {
            // Credêncial de Conexão com Banco de dados.
            string Credencial = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ListME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // Definição da Conexão em um Banco de dados Sql Server.
            Configuracao.UseSqlServer(Credencial);
        }
    }
}
