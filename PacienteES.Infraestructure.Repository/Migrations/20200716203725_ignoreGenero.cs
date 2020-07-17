using Microsoft.EntityFrameworkCore.Migrations;

namespace PacienteES.Infraestructure.Repository.Migrations
{
    public partial class ignoreGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "GeneroAcompananteId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "GeneroId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoIdAcompananteId",
                table: "Paciente");

            migrationBuilder.DropColumn(
                name: "TipoIdId",
                table: "Paciente");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GeneroAcompananteId",
                table: "Paciente",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GeneroId",
                table: "Paciente",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoIdAcompananteId",
                table: "Paciente",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TipoIdId",
                table: "Paciente",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoIdentificacion",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
        }
    }
}
