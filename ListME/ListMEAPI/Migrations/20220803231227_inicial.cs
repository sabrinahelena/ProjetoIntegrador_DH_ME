using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ListMEAPI.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Acessos",
                columns: table => new
                {
                    Id_Acesso = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessos", x => x.Id_Acesso);
                });

            migrationBuilder.CreateTable(
                name: "Estoque",
                columns: table => new
                {
                    Id_Estoque = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data_Validade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantidade_Estoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estoque", x => x.Id_Estoque);
                });

            migrationBuilder.CreateTable(
                name: "Produtos da lista de compras",
                columns: table => new
                {
                    Id_Produtos = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao_Produtos = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<float>(type: "real", nullable: false),
                    Quantidade_Produtos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos da lista de compras", x => x.Id_Produtos);
                });

            migrationBuilder.CreateTable(
                name: "Residências",
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
                    table.PrimaryKey("PK_Residências", x => x.Id_Residencias);
                });

            migrationBuilder.CreateTable(
                name: "Usuários",
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
                    table.PrimaryKey("PK_Usuários", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "RelacaoUsuarioResidencia",
                columns: table => new
                {
                    Id_UsuarioRelacaoResidencia = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuarioRelacaoResidenciaId_Usuario = table.Column<int>(type: "int", nullable: false),
                    residenciaRelacaoResidenciaId_Residencias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RelacaoUsuarioResidencia", x => x.Id_UsuarioRelacaoResidencia);
                    table.ForeignKey(
                        name: "FK_RelacaoUsuarioResidencia_Residências_residenciaRelacaoResidenciaId_Residencias",
                        column: x => x.residenciaRelacaoResidenciaId_Residencias,
                        principalTable: "Residências",
                        principalColumn: "Id_Residencias",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RelacaoUsuarioResidencia_Usuários_usuarioRelacaoResidenciaId_Usuario",
                        column: x => x.usuarioRelacaoResidenciaId_Usuario,
                        principalTable: "Usuários",
                        principalColumn: "Id_Usuario",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RelacaoUsuarioResidencia_residenciaRelacaoResidenciaId_Residencias",
                table: "RelacaoUsuarioResidencia",
                column: "residenciaRelacaoResidenciaId_Residencias");

            migrationBuilder.CreateIndex(
                name: "IX_RelacaoUsuarioResidencia_usuarioRelacaoResidenciaId_Usuario",
                table: "RelacaoUsuarioResidencia",
                column: "usuarioRelacaoResidenciaId_Usuario");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Acessos");

            migrationBuilder.DropTable(
                name: "Estoque");

            migrationBuilder.DropTable(
                name: "Produtos da lista de compras");

            migrationBuilder.DropTable(
                name: "RelacaoUsuarioResidencia");

            migrationBuilder.DropTable(
                name: "Residências");

            migrationBuilder.DropTable(
                name: "Usuários");
        }
    }
}
