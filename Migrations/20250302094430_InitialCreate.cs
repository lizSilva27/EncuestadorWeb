using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EncuestadorWeb.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EncuestaRespuestas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdEncuesta = table.Column<int>(type: "INTEGER", nullable: false),
                    IdPregunta = table.Column<int>(type: "INTEGER", nullable: false),
                    IdRespuesta = table.Column<int>(type: "INTEGER", nullable: false),
                    IdCalificacion = table.Column<int>(type: "INTEGER", nullable: false),
                    IdUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    Observaciones = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestaRespuestas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncuestaRespuestas");
        }
    }
}
