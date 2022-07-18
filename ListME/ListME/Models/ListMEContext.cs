using Microsoft.EntityFrameworkCore;

namespace ListME.Models
{
    // 1. Implementação da representação do Banco de dados Escola
    public class ListMEContext : DbContext
    {
   
        // 1.1. Adição da tabela no banco de dados.
        public DbSet<Acesso> Acesso { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<Produtos_ListaDeCompras> Produtos_ListaDeCompras { get; set; }
        public DbSet<Residencias> Residencias { get; set; }
        public DbSet<Usuario> Usuario { get; set; }

        // 1.2. Modelagem da tabela no banco de dados.

        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.Entity<Acesso>(TabelaAcesso =>
            {
                // 1.2.1. Definindo a PK da Tabela Aluno.
                TabelaAcesso.HasKey(Coluna => Coluna.Id_Acesso);
                // 1.2.2. Definindo o nome da Tabela no Database.
                TabelaAcesso.ToTable("Acessos");
                TabelaAcesso.HasOne(Tabela => Tabela.usuario);
            });

            Modelagem.Entity<Estoque>(TabelaEstoque =>
            {
                // 1.2.1. Definindo a PK da Tabela Aluno.
                TabelaEstoque.HasKey(Coluna => Coluna.Id_Estoque);
                // 1.2.2. Definindo o nome da Tabela no Database.
                TabelaEstoque.ToTable("Estoque");
                TabelaEstoque.HasMany(Tabela => Tabela.produtos);

            });

            Modelagem.Entity<Produtos_ListaDeCompras>(TabelaProdutos_ListaDeCompras =>
            {
                // 1.2.1. Definindo a PK da Tabela Aluno.
                TabelaProdutos_ListaDeCompras.HasKey(Coluna => Coluna.Id_Produtos);
                // 1.2.2. Definindo o nome da Tabela no Database.
                TabelaProdutos_ListaDeCompras.ToTable("Produtos da lista de compras");
            });


            Modelagem.Entity<Residencias>(TabelaResidencias =>
            {
                // 1.2.1. Definindo a PK da Tabela Aluno.
                TabelaResidencias.HasKey(Coluna => Coluna.Id_Residencias);
                // 1.2.2. Definindo o nome da Tabela no Database.
                TabelaResidencias.ToTable("Residências");
                TabelaResidencias.HasOne(Tabela => Tabela.estoque);

            });

            Modelagem.Entity<Usuario>(TabelaUsuario =>
            {
                // 1.2.1. Definindo a PK da Tabela Aluno.
                TabelaUsuario.HasKey(Coluna => Coluna.Id_Usuario);
                // 1.2.2. Definindo o nome da Tabela no Database.
                TabelaUsuario.ToTable("Usuários");
                TabelaUsuario.HasMany(Tabela => Tabela.produtos);
                TabelaUsuario.HasMany(Tabela => Tabela.residencias);
            });
        }

        // 1.3. Configurações de conexão com Banco de dados.
        protected override void OnConfiguring(DbContextOptionsBuilder Configuracao)
        {
            // 1.3.1. Credêncial de Conexão com Banco de dados.
            string Credencial = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ListME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            // 1.3.2. Definição da Conexão em um Banco de dados Sql Server.
            Configuracao.UseSqlServer(Credencial);
        }
    }
}
