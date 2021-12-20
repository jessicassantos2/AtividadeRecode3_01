using Microsoft.EntityFrameworkCore.Migrations;

namespace AgenciaMVC.Migrations
{
    public partial class Banco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    IdCliente = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeCliente = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    cpf = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    endereco = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    cidadeCliente = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    estadoCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.IdCliente);
                });

            migrationBuilder.CreateTable(
                name: "Destinos",
                columns: table => new
                {
                    IdDestino = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nomeDestino = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    estadoDestino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paisDestino = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    valorDiaria = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    dataInicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dataFinal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinos", x => x.IdDestino);
                });

            migrationBuilder.CreateTable(
                name: "Pacotes",
                columns: table => new
                {
                    IdPacotes = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FK_IdDestino = table.Column<int>(type: "int", nullable: false),
                    destinoIdDestino = table.Column<int>(type: "int", nullable: true),
                    FK_IdCliente = table.Column<int>(type: "int", nullable: false),
                    clienteIdCliente = table.Column<int>(type: "int", nullable: true),
                    qtdePessoas = table.Column<int>(type: "int", nullable: false),
                    qtdeDias = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacotes", x => x.IdPacotes);
                    table.ForeignKey(
                        name: "FK_Pacotes_Clientes_clienteIdCliente",
                        column: x => x.clienteIdCliente,
                        principalTable: "Clientes",
                        principalColumn: "IdCliente",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Pacotes_Destinos_destinoIdDestino",
                        column: x => x.destinoIdDestino,
                        principalTable: "Destinos",
                        principalColumn: "IdDestino",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pacotes_clienteIdCliente",
                table: "Pacotes",
                column: "clienteIdCliente");

            migrationBuilder.CreateIndex(
                name: "IX_Pacotes_destinoIdDestino",
                table: "Pacotes",
                column: "destinoIdDestino");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacotes");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Destinos");
        }
    }
}
