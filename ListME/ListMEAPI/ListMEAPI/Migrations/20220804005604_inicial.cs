using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListMEAPI.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id_Estoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id_Estoque);
                });

            migrationBuilder.CreateTable(
                name: "Lista de compras",
                columns: table => new
                {
                    Id_ListaDeCompras = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lista de compras", x => x.Id_ListaDeCompras);
                });

            migrationBuilder.CreateTable(
                name: "Residencias",
                columns: table => new
                {
                    Id_Residencias = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Foto_Residencias = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Residencias", x => x.Id_Residencias);
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
                    Foto_Perfil = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id_Produtos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Data_Validade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantidade_Produto = table.Column<int>(type: "int", nullable: true),
                    ListaComprasModelId_ListaDeCompras = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id_Produtos);
                    table.ForeignKey(
                        name: "FK_Produtos_Lista de compras_ListaComprasModelId_ListaDeCompras",
                        column: x => x.ListaComprasModelId_ListaDeCompras,
                        principalTable: "Lista de compras",
                        principalColumn: "Id_ListaDeCompras");
                });

            migrationBuilder.CreateTable(
                name: "Relacao Usuario",
                columns: table => new
                {
                    Id_Relacionamento = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_Usuario1 = table.Column<int>(type: "int", nullable: false),
                    Id_Residencias = table.Column<int>(type: "int", nullable: false),
                    Id_Estoque1 = table.Column<int>(type: "int", nullable: false),
                    Id_ListaComprasId_ListaDeCompras = table.Column<int>(type: "int", nullable: false),
                    Id_Produtos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Relacao Usuario", x => x.Id_Relacionamento);
                    table.ForeignKey(
                        name: "FK_Relacao Usuario_Estoque_Id_Estoque1",
                        column: x => x.Id_Estoque1,
                        principalTable: "Estoque",
                        principalColumn: "Id_Estoque",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relacao Usuario_Lista de compras_Id_ListaComprasId_ListaDeCompras",
                        column: x => x.Id_ListaComprasId_ListaDeCompras,
                        principalTable: "Lista de compras",
                        principalColumn: "Id_ListaDeCompras",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relacao Usuario_Produtos_Id_Produtos",
                        column: x => x.Id_Produtos,
                        principalTable: "Produtos",
                        principalColumn: "Id_Produtos",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relacao Usuario_Residencias_Id_Residencias",
                        column: x => x.Id_Residencias,
                        principalTable: "Residencias",
                        principalColumn: "Id_Residencias",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Relacao Usuario_Usuarios_Id_Usuario1",
                        column: x => x.Id_Usuario1,
                        principalTable: "Usuarios",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ListaComprasModelId_ListaDeCompras",
                table: "Produtos",
                column: "ListaComprasModelId_ListaDeCompras");

            migrationBuilder.CreateIndex(
                name: "IX_Relacao Usuario_Id_Estoque1",
                table: "Relacao Usuario",
                column: "Id_Estoque1");

            migrationBuilder.CreateIndex(
                name: "IX_Relacao Usuario_Id_ListaComprasId_ListaDeCompras",
                table: "Relacao Usuario",
                column: "Id_ListaComprasId_ListaDeCompras");

            migrationBuilder.CreateIndex(
                name: "IX_Relacao Usuario_Id_Produtos",
                table: "Relacao Usuario",
                column: "Id_Produtos");

            migrationBuilder.CreateIndex(
                name: "IX_Relacao Usuario_Id_Residencias",
                table: "Relacao Usuario",
                column: "Id_Residencias");

            migrationBuilder.CreateIndex(
                name: "IX_Relacao Usuario_Id_Usuario1",
                table: "Relacao Usuario",
                column: "Id_Usuario1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Relacao Usuario");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Residencias");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Lista de compras");
        }
    }
}
