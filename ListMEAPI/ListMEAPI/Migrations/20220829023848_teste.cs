using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListMEAPI.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acessos",
                columns: table => new
                {
                    Id_Acesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessos", x => x.Id_Acesso);
                });

            migrationBuilder.CreateTable(
                name: "Contatos",
                columns: table => new
                {
                    Id_Contato = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mensagem = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contatos", x => x.Id_Contato);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id_Produtos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id_Produtos);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data_Nascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto_Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Residencias",
                columns: table => new
                {
                    Id_Residencias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Id_Usuario = table.Column<int>(type: "int", nullable: false),
                    UsuarioModelId_Usuario = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residencias", x => x.Id_Residencias);
                    table.ForeignKey(
                        name: "FK_Residencias_Usuarios_UsuarioModelId_Usuario",
                        column: x => x.UsuarioModelId_Usuario,
                        principalTable: "Usuarios",
                        principalColumn: "Id_Usuario");
                });

            migrationBuilder.CreateTable(
                name: "Estoques",
                columns: table => new
                {
                    Id_Estoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdResidencia = table.Column<int>(type: "int", nullable: false),
                    ProdutoId_Produtos = table.Column<int>(type: "int", nullable: false),
                    Quantidade_Produto = table.Column<int>(type: "int", nullable: false),
                    Data_Validade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Id_Lista = table.Column<int>(type: "int", nullable: false),
                    ResidenciaModelId_Residencias = table.Column<int>(type: "int", nullable: true),
                    ResidenciaModelId_Residencias1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoques", x => x.Id_Estoque);
                    table.ForeignKey(
                        name: "FK_Estoques_Produtos_ProdutoId_Produtos",
                        column: x => x.ProdutoId_Produtos,
                        principalTable: "Produtos",
                        principalColumn: "Id_Produtos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Estoques_Residencias_ResidenciaModelId_Residencias",
                        column: x => x.ResidenciaModelId_Residencias,
                        principalTable: "Residencias",
                        principalColumn: "Id_Residencias");
                    table.ForeignKey(
                        name: "FK_Estoques_Residencias_ResidenciaModelId_Residencias1",
                        column: x => x.ResidenciaModelId_Residencias1,
                        principalTable: "Residencias",
                        principalColumn: "Id_Residencias");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ProdutoId_Produtos",
                table: "Estoques",
                column: "ProdutoId_Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ResidenciaModelId_Residencias",
                table: "Estoques",
                column: "ResidenciaModelId_Residencias");

            migrationBuilder.CreateIndex(
                name: "IX_Estoques_ResidenciaModelId_Residencias1",
                table: "Estoques",
                column: "ResidenciaModelId_Residencias1");

            migrationBuilder.CreateIndex(
                name: "IX_Residencias_UsuarioModelId_Usuario",
                table: "Residencias",
                column: "UsuarioModelId_Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acessos");

            migrationBuilder.DropTable(
                name: "Contatos");

            migrationBuilder.DropTable(
                name: "Estoques");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Residencias");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
