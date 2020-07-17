using Microsoft.EntityFrameworkCore.Migrations;

namespace PacienteES.Infraestructure.Repository.Migrations
{
    public partial class includetipoidentificacionOwned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TipoId_Id",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoId_Name",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoIdAcompanante_Id",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoIdAcompanante_Name",
                table: "Paciente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TipoId_Id",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoId_Name",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoIdAcompanante_Id",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoIdAcompanante_Name",
                table: "Paciente");
        }
    }
}
