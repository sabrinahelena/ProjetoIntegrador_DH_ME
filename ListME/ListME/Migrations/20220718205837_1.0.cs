using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListME.Migrations
{
    public partial class _10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id_Estoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Validade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantidade_Estoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id_Estoque);
                });

            migrationBuilder.CreateTable(
                name: "Usuários",
                columns: table => new
                {
                    Id_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Nome_Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data_Nascimento = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto_Perfil = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuários", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Acessos",
                columns: table => new
                {
                    Id_Acesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    usuarioId_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessos", x => x.Id_Acesso);
                    table.ForeignKey(
                        name: "FK_Acessos_Usuários_usuarioId_Usuario",
                        column: x => x.usuarioId_Usuario,
                        principalTable: "Usuários",
                        principalColumn: "Id_Usuario");
                });

            migrationBuilder.CreateTable(
                name: "Produtos da lista de compras",
                columns: table => new
                {
                    Id_Produtos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Quantidade_Produtos = table.Column<int>(type: "int", nullable: false),
                    EstoqueId_Estoque = table.Column<int>(type: "int", nullable: true),
                    UsuarioId_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos da lista de compras", x => x.Id_Produtos);
                    table.ForeignKey(
                        name: "FK_Produtos da lista de compras_Estoque_EstoqueId_Estoque",
                        column: x => x.EstoqueId_Estoque,
                        principalTable: "Estoque",
                        principalColumn: "Id_Estoque");
                    table.ForeignKey(
                        name: "FK_Produtos da lista de compras_Usuários_UsuarioId_Usuario",
                        column: x => x.UsuarioId_Usuario,
                        principalTable: "Usuários",
                        principalColumn: "Id_Usuario");
                });

            migrationBuilder.CreateTable(
                name: "Residências",
                columns: table => new
                {
                    Id_Residencias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Foto_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estoqueId_Estoque = table.Column<int>(type: "int", nullable: false),
                    UsuarioId_Usuario = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residências", x => x.Id_Residencias);
                    table.ForeignKey(
                        name: "FK_Residências_Estoque_estoqueId_Estoque",
                        column: x => x.estoqueId_Estoque,
                        principalTable: "Estoque",
                        principalColumn: "Id_Estoque",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Residências_Usuários_UsuarioId_Usuario",
                        column: x => x.UsuarioId_Usuario,
                        principalTable: "Usuários",
                        principalColumn: "Id_Usuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Acessos_usuarioId_Usuario",
                table: "Acessos",
                column: "usuarioId_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos da lista de compras_EstoqueId_Estoque",
                table: "Produtos da lista de compras",
                column: "EstoqueId_Estoque");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos da lista de compras_UsuarioId_Usuario",
                table: "Produtos da lista de compras",
                column: "UsuarioId_Usuario");

            migrationBuilder.CreateIndex(
                name: "IX_Residências_estoqueId_Estoque",
                table: "Residências",
                column: "estoqueId_Estoque");

            migrationBuilder.CreateIndex(
                name: "IX_Residências_UsuarioId_Usuario",
                table: "Residências",
                column: "UsuarioId_Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acessos");

            migrationBuilder.DropTable(
                name: "Produtos da lista de compras");

            migrationBuilder.DropTable(
                name: "Residências");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Usuários");
        }
    }
}
