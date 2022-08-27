using Microsoft.EntityFrameworkCore;

namespace ListMEAPI.Models
{
    public partial class ListMEContext : DbContext
    {
        public ListMEContext()
        {

        }
        public ListMEContext(DbContextOptions<ListMEContext> options) : base(options)
        {

        }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<EstoqueModel>? Estoques { get; set; }
        public DbSet<ProdutosModel>? Produtos { get; set; }
        public DbSet<ResidenciaModel>? Residencias { get; set; }
        public DbSet<ContatoModel>? Contatos { get; set; }
        public DbSet<AcessoModel>? Acessos { get; set; }


        protected override void OnModelCreating(ModelBuilder Modelagem)
        {
            Modelagem.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");
            Modelagem.Entity<UsuarioModel>(entity =>
            {
                entity.HasKey(e => e.Id_Usuario);
                entity.ToTable("usuario_table");
                entity.Property(e => e.Id_Usuario).HasColumnName("id_usuarioDb");
                entity.Property(e => e.Nome_Usuario)
                .HasMaxLength(15).IsUnicode(false).HasColumnName("nome_usuarioDb");
                entity.Property(e => e.Sobrenome)
                .HasMaxLength(15).IsUnicode(false).HasColumnName("sobrenome_usuarioDb");
                entity.Property(e => e.Telefone)
                .HasMaxLength(13).IsUnicode(false).HasColumnName("telefone_usuarioDb");
                //Parte da DATA faço assim?
                entity.Property(e => e.Data_Nascimento).HasColumnName("nascimento_usuario");
                entity.Property(e => e.Email)
                .HasMaxLength(30).IsUnicode(false).HasColumnName("email_usuarioDb");
                entity.Property(e => e.Foto_Perfil)
                .HasMaxLength(200).IsUnicode(false).HasColumnName("foto_usuarioDb");
                entity.Property(e => e.Senha)
                .HasMaxLength(16).IsUnicode(false).HasColumnName("senha_usuarioDb");


            });
            // ACESSO!!
            //Modelagem.Entity<AcessoModel>(entity =>
            //{
            //    entity.HasKey(e => e.Id_Acesso);
            //    entity.ToTable("acesso_table");
            //    entity.Property(e => e.Id_Acesso).HasColumnName("id_acessoDb");
            //    entity.Property(e => e.email)
            //    .HasMaxLength(30).IsUnicode(false).HasColumnName("email_acessoDb");
            //    entity.Property(e => e.senha)
            //    .HasMaxLength(16).IsUnicode(false).HasColumnName("senha_acessoDb");


            //});

            Modelagem.Entity<ContatoModel>(entity =>
            {
                entity.HasKey(e => e.Id_Contato);
                entity.ToTable("contato_table");
                entity.Property(e => e.Id_Contato).HasColumnName("id_contatoDb");
                entity.Property(e => e.Nome)
                .HasMaxLength(20).IsUnicode(false).HasColumnName("nome_contatoDb");
                entity.Property(e => e.Email)
                .HasMaxLength(30).IsUnicode(false).HasColumnName("email_contatoDb");
                entity.Property(e => e.Mensagem)
                .HasMaxLength(300).IsUnicode(false).HasColumnName("mensagem_contatoDb");
            });

            

            //Modelagem.Entity<EstoqueModel>(TabelaEstoque =>
            //{
            //   TabelaEstoque.HasKey(Coluna => Coluna.Id_Estoque);
            //    TabelaEstoque.ToTable("Estoque");
            //});
            //Modelagem.Entity<ProdutosModel>(TabelaProduto =>
            //{
            //    TabelaProduto.HasKey(Coluna => Coluna.Id_Produtos);
            //    TabelaProduto.ToTable("Produtos");
            //});
            //Modelagem.Entity<ListaComprasModel>(TabelaListaCompras =>
            //{
            //    TabelaListaCompras.HasKey(Coluna => Coluna.Id_ListaDeCompras);
            //    TabelaListaCompras.ToTable("Lista de compras");
            //});
            //Modelagem.Entity<ContatoModel>(TabelaContato =>
            //{
            //       TabelaContato.HasKey(Coluna => Coluna.Id_Contato);
            //    TabelaContato.ToTable("Tabela de contato");
            //});

            OnModelCreatingPartial(Modelagem);

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        //protected override void OnConfiguring(DbContextOptionsBuilder Configuracao)
        //{
        //    // Credêncial de Conexão com Banco de dados.
        //    // string Credencial = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ListME;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        //    // Definição da Conexão em um Banco de dados Sql Server.
        //    Configuracao.UseInMemoryDatabase("ListME-InMemory");
        //}
    }
}
