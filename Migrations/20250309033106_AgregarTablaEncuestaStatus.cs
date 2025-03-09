using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EncuestadorWeb.Migrations
{
    public partial class AgregarTablaEncuestaStatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EncuestasStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdUsuario = table.Column<int>(type: "INTEGER", nullable: false),
                    IdEncuestaAsig = table.Column<int>(type: "INTEGER", nullable: false),
                    StatusEncuesta = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EncuestasStatus", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EncuestasStatus");
        }
    }
}
