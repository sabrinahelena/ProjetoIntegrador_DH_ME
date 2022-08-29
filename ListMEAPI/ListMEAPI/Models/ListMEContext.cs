using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Models
{
    public class ListMEContext : DbContext
    {
        public ListMEContext(DbContextOptions<ListMEContext> options) : base(options)
        {

        }
        public virtual DbSet<UsuarioModel>? Usuarios { get; set; }
        public virtual DbSet<ResidenciaModel>? Residencias { get; set; }
        public virtual DbSet<ContatoModel>? Contatos { get; set; }

        public virtual DbSet<AcessoModel>? Acessos { get; set; }
        public virtual DbSet<EstoqueModel> Estoques { get; set; }
        public virtual DbSet<ProdutosModel> Produtos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder Configuracao)
        {
            // Credêncial de Conexão com Banco de dados.
            string Credencial  = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ListMeTDD;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Configuracao.UseSqlServer(Credencial);
            
        }
    }
}
