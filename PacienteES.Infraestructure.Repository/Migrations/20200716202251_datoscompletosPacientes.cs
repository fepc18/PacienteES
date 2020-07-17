using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PacienteES.Infraestructure.Repository.Migrations
{
    public partial class datoscompletosPacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Zona_ZonaId",
                table: "Paciente");

            migrationBuilder.AlterColumn<string>(
                name: "ZonaId",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Paciente",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Activo",
                table: "Paciente",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Barrio",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BarrioAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Carnet",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Celular",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DireccionAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EscolaridadId",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EstadoCivilId",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EtniaId",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimientoAcompanante",
                table: "Paciente",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "GeneroAcompananteId",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneroId",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Identificacion",
                table: "Paciente",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentificacionAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LugarExpedicion",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LugarExpedicionAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Municipio",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MunicipioAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NivelId",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Ocupacion",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OcupacionAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimerApellidoAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PrimerNombreAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RegimenId",
                table: "Paciente",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "SegundoApellidoAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SegundoNombreAcompanante",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefono",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoAfiliadoId",
                table: "Paciente",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoIdAcompananteId",
                table: "Paciente",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoIdId",
                table: "Paciente",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TipoSangre",
                table: "Paciente",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificacion",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoIdentificacion", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_GeneroAcompananteId",
                table: "Paciente",
                column: "GeneroAcompananteId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_GeneroId",
                table: "Paciente",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TipoIdAcompananteId",
                table: "Paciente",
                column: "TipoIdAcompananteId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_TipoIdId",
                table: "Paciente",
                column: "TipoIdId");

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Genero_GeneroAcompananteId",
                table: "Paciente",
                column: "GeneroAcompananteId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Genero_GeneroId",
                table: "Paciente",
                column: "GeneroId",
                principalTable: "Genero",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_TipoIdentificacion_TipoIdAcompananteId",
                table: "Paciente",
                column: "TipoIdAcompananteId",
                principalTable: "TipoIdentificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_TipoIdentificacion_TipoIdId",
                table: "Paciente",
                column: "TipoIdId",
                principalTable: "TipoIdentificacion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Zona_ZonaId",
                table: "Paciente",
                column: "ZonaId",
                principalTable: "Zona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Genero_GeneroAcompananteId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Genero_GeneroId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_TipoIdentificacion_TipoIdAcompananteId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_TipoIdentificacion_TipoIdId",
                table: "Paciente");

            migrationBuilder.DropForeignKey(
                name: "FK_Paciente_Zona_ZonaId",
                table: "Paciente");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "TipoIdentificacion");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_GeneroAcompananteId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_GeneroId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_TipoIdAcompananteId",
                table: "Paciente");

            migrationBuilder.DropIndex(
                name: "IX_Paciente_TipoIdId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Activo",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Barrio",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "BarrioAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Carnet",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Celular",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "DireccionAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "EscolaridadId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "EstadoCivilId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "EtniaId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "FechaNacimientoAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "GeneroAcompananteId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Identificacion",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "IdentificacionAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "LugarExpedicion",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "LugarExpedicionAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Municipio",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "MunicipioAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "NivelId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Ocupacion",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "OcupacionAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "PrimerApellidoAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "PrimerNombreAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "RegimenId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "SegundoApellidoAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "SegundoNombreAcompanante",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "Telefono",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoAfiliadoId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoIdAcompananteId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoIdId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoSangre",
                table: "Paciente");

            migrationBuilder.AlterColumn<string>(
                name: "ZonaId",
                table: "Paciente",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PrimerNombre",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "PrimerApellido",
                table: "Paciente",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddForeignKey(
                name: "FK_Paciente_Zona_ZonaId",
                table: "Paciente",
                column: "ZonaId",
                principalTable: "Zona",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
