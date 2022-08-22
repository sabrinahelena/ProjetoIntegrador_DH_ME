using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Models
{
    public class ListMEContext : DbContext
    {
        public ListMEContext(DbContextOptions<ListMEContext> options) : base(options)
        {

        }
        public DbSet<UsuarioModel>? Usuarios { get; set; }
        //public DbSet<EstoqueModel>? Estoque { get; set; }
        //public DbSet<ProdutosModel>? Produtos { get; set; }
       // public DbSet<ListaComprasModel>? ListaCompras { get; set; }
        public DbSet<ResidenciaModel>? Residencias { get; set; }
        public DbSet<ContatoModel>? Contatos { get; set; }

        public DbSet<AcessoModel>? Acessos { get; set; }
        public DbSet<EstoqueModel> Estoques { get; set; }
        public DbSet<ProdutosModel> Produtos { get; set; }
        //public DbSet<ListaComprasModel> ListaDeCompras { get; set; }
        //protected override void OnModelCreating(ModelBuilder Modelagem)
        //{
        //    //Modelagem.Entity<EstoqueModel>(TabelaEstoque =>
        //    //{
        //    //    TabelaEstoque.HasKey(Coluna => Coluna.Id_Estoque);
        //    //    TabelaEstoque.ToTable("Estoque");
        //    //});
        //    //Modelagem.Entity<ProdutosModel>(TabelaProduto =>
        //    //{
        //    //    TabelaProduto.HasKey(Coluna => Coluna.Id_Produtos);
        //    //    TabelaProduto.ToTable("Produtos");
        //    //});
        //    //Modelagem.Entity<ListaComprasModel>(TabelaListaCompras =>
        //    //{
        //    //    TabelaListaCompras.HasKey(Coluna => Coluna.Id_ListaDeCompras);
        //    //    TabelaListaCompras.ToTable("Lista de compras");
        //    //});
        //    //Modelagem.Entity<ContatoModel>(TabelaContato =>
        //    //{
        //    //    TabelaContato.HasKey(Coluna => Coluna.Id_Contato);
        //    //    TabelaContato.ToTable("Tabela de contato");
        //    //});



        //}
        protected override void OnConfiguring(DbContextOptionsBuilder Configuracao)
        {
            // Credêncial de Conexão com Banco de dados.
            // string Credencial = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ListME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // Definição da Conexão em um Banco de dados Sql Server.
            Configuracao.UseInMemoryDatabase("ListME-InMemory");
        }
    }
}
