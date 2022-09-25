using Microsoft.EntityFrameworkCore.Migrations;

namespace MantComputadores.App.Persistencia.Migrations
{
    public partial class TerceraMigracion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_historiales_citasagendadas_citasagendadasId",
                table: "historiales");

            migrationBuilder.DropForeignKey(
                name: "FK_historiales_ordenservicios_ordenserviciosId",
                table: "historiales");

            migrationBuilder.DropForeignKey(
                name: "FK_historiales_serviciosprestados_serviciosprestadosId",
                table: "historiales");

            migrationBuilder.RenameColumn(
                name: "serviciosprestadosId",
                table: "historiales",
                newName: "_serviciosprestadosId");

            migrationBuilder.RenameColumn(
                name: "ordenserviciosId",
                table: "historiales",
                newName: "_ordenserviciosId");

            migrationBuilder.RenameColumn(
                name: "citasagendadasId",
                table: "historiales",
                newName: "_citasagendadasId");

            migrationBuilder.RenameIndex(
                name: "IX_historiales_serviciosprestadosId",
                table: "historiales",
                newName: "IX_historiales__serviciosprestadosId");

            migrationBuilder.RenameIndex(
                name: "IX_historiales_ordenserviciosId",
                table: "historiales",
                newName: "IX_historiales__ordenserviciosId");

            migrationBuilder.RenameIndex(
                name: "IX_historiales_citasagendadasId",
                table: "historiales",
                newName: "IX_historiales__citasagendadasId");

            migrationBuilder.AlterColumn<string>(
                name: "RazonSocial",
                table: "regpersonas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_historiales_citasagendadas__citasagendadasId",
                table: "historiales",
                column: "_citasagendadasId",
                principalTable: "citasagendadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_historiales_ordenservicios__ordenserviciosId",
                table: "historiales",
                column: "_ordenserviciosId",
                principalTable: "ordenservicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_historiales_serviciosprestados__serviciosprestadosId",
                table: "historiales",
                column: "_serviciosprestadosId",
                principalTable: "serviciosprestados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_historiales_citasagendadas__citasagendadasId",
                table: "historiales");

            migrationBuilder.DropForeignKey(
                name: "FK_historiales_ordenservicios__ordenserviciosId",
                table: "historiales");

            migrationBuilder.DropForeignKey(
                name: "FK_historiales_serviciosprestados__serviciosprestadosId",
                table: "historiales");

            migrationBuilder.RenameColumn(
                name: "_serviciosprestadosId",
                table: "historiales",
                newName: "serviciosprestadosId");

            migrationBuilder.RenameColumn(
                name: "_ordenserviciosId",
                table: "historiales",
                newName: "ordenserviciosId");

            migrationBuilder.RenameColumn(
                name: "_citasagendadasId",
                table: "historiales",
                newName: "citasagendadasId");

            migrationBuilder.RenameIndex(
                name: "IX_historiales__serviciosprestadosId",
                table: "historiales",
                newName: "IX_historiales_serviciosprestadosId");

            migrationBuilder.RenameIndex(
                name: "IX_historiales__ordenserviciosId",
                table: "historiales",
                newName: "IX_historiales_ordenserviciosId");

            migrationBuilder.RenameIndex(
                name: "IX_historiales__citasagendadasId",
                table: "historiales",
                newName: "IX_historiales_citasagendadasId");

            migrationBuilder.AlterColumn<int>(
                name: "RazonSocial",
                table: "regpersonas",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_historiales_citasagendadas_citasagendadasId",
                table: "historiales",
                column: "citasagendadasId",
                principalTable: "citasagendadas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_historiales_ordenservicios_ordenserviciosId",
                table: "historiales",
                column: "ordenserviciosId",
                principalTable: "ordenservicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_historiales_serviciosprestados_serviciosprestadosId",
                table: "historiales",
                column: "serviciosprestadosId",
                principalTable: "serviciosprestados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
