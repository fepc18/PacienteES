using Microsoft.EntityFrameworkCore.Migrations;

namespace PacienteES.Infraestructure.Repository.Migrations
{
    public partial class pacienteOnlyPrimitives : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Genero",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneroAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoId",
                table: "Paciente",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoIdAcompanante",
                table: "Paciente",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genero",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "GeneroAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoIdAcompanante",
                table: "Paciente");

            migrationBuilder.AddColumn<string>(
                name: "TipoId_Id",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoId_Name",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoIdAcompanante_Id",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoIdAcompanante_Name",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
