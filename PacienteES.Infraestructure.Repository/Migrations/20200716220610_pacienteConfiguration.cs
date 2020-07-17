using Microsoft.EntityFrameworkCore.Migrations;

namespace PacienteES.Infraestructure.Repository.Migrations
{
    public partial class pacienteConfiguration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ZonaId",
                table: "Paciente");

            migrationBuilder.AddColumn<string>(
                name: "Zona",
                table: "Paciente",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Zona",
                table: "Paciente");

            migrationBuilder.AddColumn<string>(
                name: "ZonaId",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
