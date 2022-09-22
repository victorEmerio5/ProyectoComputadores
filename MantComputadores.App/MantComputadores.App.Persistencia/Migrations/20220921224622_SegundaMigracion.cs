using Microsoft.EntityFrameworkCore.Migrations;

namespace MantComputadores.App.Persistencia.Migrations
{
    public partial class SegundaMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_citasagendadas_citasagendadasId",
                table: "regpersonas");

            migrationBuilder.RenameColumn(
                name: "citasagendadasId",
                table: "regpersonas",
                newName: "_serviciosprestadosId");

            migrationBuilder.RenameIndex(
                name: "IX_regpersonas_citasagendadasId",
                table: "regpersonas",
                newName: "IX_regpersonas__serviciosprestadosId");

            migrationBuilder.AddColumn<int>(
                name: "Tecnico__loginId",
                table: "regpersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_citasagendadasId",
                table: "regpersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_historialId",
                table: "regpersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_loginId",
                table: "regpersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_mediodepagoId",
                table: "regpersonas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "_ordenserviciosId",
                table: "regpersonas",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "login",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contraseña = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_login", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_regpersonas__citasagendadasId",
                table: "regpersonas",
                column: "_citasagendadasId");

            migrationBuilder.CreateIndex(
                name: "IX_regpersonas__historialId",
                table: "regpersonas",
                column: "_historialId");

            migrationBuilder.CreateIndex(
                name: "IX_regpersonas__loginId",
                table: "regpersonas",
                column: "_loginId");

            migrationBuilder.CreateIndex(
                name: "IX_regpersonas__mediodepagoId",
                table: "regpersonas",
                column: "_mediodepagoId");

            migrationBuilder.CreateIndex(
                name: "IX_regpersonas__ordenserviciosId",
                table: "regpersonas",
                column: "_ordenserviciosId");

            migrationBuilder.CreateIndex(
                name: "IX_regpersonas_Tecnico__loginId",
                table: "regpersonas",
                column: "Tecnico__loginId");

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_citasagendadas__citasagendadasId",
                table: "regpersonas",
                column: "_citasagendadasId",
                principalTable: "citasagendadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_historiales__historialId",
                table: "regpersonas",
                column: "_historialId",
                principalTable: "historiales",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_login__loginId",
                table: "regpersonas",
                column: "_loginId",
                principalTable: "login",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_login_Tecnico__loginId",
                table: "regpersonas",
                column: "Tecnico__loginId",
                principalTable: "login",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_mediodepagos__mediodepagoId",
                table: "regpersonas",
                column: "_mediodepagoId",
                principalTable: "mediodepagos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_ordenservicios__ordenserviciosId",
                table: "regpersonas",
                column: "_ordenserviciosId",
                principalTable: "ordenservicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_serviciosprestados__serviciosprestadosId",
                table: "regpersonas",
                column: "_serviciosprestadosId",
                principalTable: "serviciosprestados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_citasagendadas__citasagendadasId",
                table: "regpersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_historiales__historialId",
                table: "regpersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_login__loginId",
                table: "regpersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_login_Tecnico__loginId",
                table: "regpersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_mediodepagos__mediodepagoId",
                table: "regpersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_ordenservicios__ordenserviciosId",
                table: "regpersonas");

            migrationBuilder.DropForeignKey(
                name: "FK_regpersonas_serviciosprestados__serviciosprestadosId",
                table: "regpersonas");

            migrationBuilder.DropTable(
                name: "login");

            migrationBuilder.DropIndex(
                name: "IX_regpersonas__citasagendadasId",
                table: "regpersonas");

            migrationBuilder.DropIndex(
                name: "IX_regpersonas__historialId",
                table: "regpersonas");

            migrationBuilder.DropIndex(
                name: "IX_regpersonas__loginId",
                table: "regpersonas");

            migrationBuilder.DropIndex(
                name: "IX_regpersonas__mediodepagoId",
                table: "regpersonas");

            migrationBuilder.DropIndex(
                name: "IX_regpersonas__ordenserviciosId",
                table: "regpersonas");

            migrationBuilder.DropIndex(
                name: "IX_regpersonas_Tecnico__loginId",
                table: "regpersonas");

            migrationBuilder.DropColumn(
                name: "Tecnico__loginId",
                table: "regpersonas");

            migrationBuilder.DropColumn(
                name: "_citasagendadasId",
                table: "regpersonas");

            migrationBuilder.DropColumn(
                name: "_historialId",
                table: "regpersonas");

            migrationBuilder.DropColumn(
                name: "_loginId",
                table: "regpersonas");

            migrationBuilder.DropColumn(
                name: "_mediodepagoId",
                table: "regpersonas");

            migrationBuilder.DropColumn(
                name: "_ordenserviciosId",
                table: "regpersonas");

            migrationBuilder.RenameColumn(
                name: "_serviciosprestadosId",
                table: "regpersonas",
                newName: "citasagendadasId");

            migrationBuilder.RenameIndex(
                name: "IX_regpersonas__serviciosprestadosId",
                table: "regpersonas",
                newName: "IX_regpersonas_citasagendadasId");

            migrationBuilder.AddForeignKey(
                name: "FK_regpersonas_citasagendadas_citasagendadasId",
                table: "regpersonas",
                column: "citasagendadasId",
                principalTable: "citasagendadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
