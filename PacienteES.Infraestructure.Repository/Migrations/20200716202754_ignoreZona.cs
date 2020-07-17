using Microsoft.EntityFrameworkCore.Migrations;

namespace PacienteES.Infraestructure.Repository.Migrations
{
    public partial class ignoreZona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Zona_ZonaId",
                table: "Paciente");

            migrationBuilder.DropTable(
                name: "Zona");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_ZonaId",
                table: "Paciente");

            migrationBuilder.AlterColumn<string>(
                name: "ZonaId",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZonaId",
                table: "Paciente",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.CreateTable(
                name: "Zona",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zona", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_ZonaId",
                table: "Paciente",
                column: "ZonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Zona_ZonaId",
                table: "Paciente",
                column: "ZonaId",
                principalTable: "Zona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
