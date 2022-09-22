using Microsoft.EntityFrameworkCore.Migrations;

namespace MantComputadores.App.Persistencia.Migrations
{
    public partial class MigracionInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mediodepagos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    efectivo = table.Column<bool>(type: "bit", nullable: false),
                    Giro = table.Column<bool>(type: "bit", nullable: false),
                    Transferencia = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mediodepagos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ordenservicios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombresCliente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NonbresTecnico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Horario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorServicio = table.Column<double>(type: "float", nullable: false),
                    ComisionTecnico = table.Column<double>(type: "float", nullable: false),
                    TotalPagar = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ordenservicios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "serviciosprestados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoServicio = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Piezas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrecioPiezas = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_serviciosprestados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "historiales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    citasagendadasId = table.Column<int>(type: "int", nullable: true),
                    serviciosprestadosId = table.Column<int>(type: "int", nullable: true),
                    ordenserviciosId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_historiales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_historiales_ordenservicios_ordenserviciosId",
                        column: x => x.ordenserviciosId,
                        principalTable: "ordenservicios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_historiales_serviciosprestados_serviciosprestadosId",
                        column: x => x.serviciosprestadosId,
                        principalTable: "serviciosprestados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "regpersonas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumTelefono = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    citasagendadasId = table.Column<int>(type: "int", nullable: true),
                    RazonSocial = table.Column<int>(type: "int", nullable: true),
                    IdProfesional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NivelAcademico = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regpersonas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "citasagendadas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    regpersonaId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoServicio = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citasagendadas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_citasagendadas_regpersonas_regpersonaId",
                        column: x => x.regpersonaId,
                        principalTable: "regpersonas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_citasagendadas_regpersonaId",
                table: "citasagendadas",
                column: "regpersonaId");

            migrationBuilder.CreateIndex(
                name: "IX_historiales_citasagendadasId",
                table: "historiales",
                column: "citasagendadasId");

            migrationBuilder.CreateIndex(
                name: "IX_historiales_ordenserviciosId",
                table: "historiales",
                column: "ordenserviciosId");

            migrationBuilder.CreateIndex(
                name: "IX_historiales_serviciosprestadosId",
                table: "historiales",
                column: "serviciosprestadosId");

            migrationBuilder.CreateIndex(
                name: "IX_regpersonas_citasagendadasId",
                table: "regpersonas",
                column: "citasagendadasId");

            migrationBuilder.AddForeignKey(
                name: "FK_historiales_citasagendadas_citasagendadasId",
                table: "historiales",
                column: "citasagendadasId",
                principalTable: "citasagendadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_citasagendadas_citasagendadasId",
                table: "regpersonas",
                column: "citasagendadasId",
                principalTable: "citasagendadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_citasagendadas_regpersonas_regpersonaId",
                table: "citasagendadas");

            migrationBuilder.DropTable(
                name: "historiales");

            migrationBuilder.DropTable(
                name: "mediodepagos");

            migrationBuilder.DropTable(
                name: "ordenservicios");

            migrationBuilder.DropTable(
                name: "serviciosprestados");

            migrationBuilder.DropTable(
                name: "regpersonas");

            migrationBuilder.DropTable(
                name: "citasagendadas");
        }
    }
}
