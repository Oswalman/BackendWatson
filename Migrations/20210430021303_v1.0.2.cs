using Microsoft.EntityFrameworkCore.Migrations;

namespace Prueba_Watson.Migrations
{
    public partial class v102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SumaDocumento",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SumaNombres",
                table: "Persona",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SumaDocumento",
                table: "Persona");

            migrationBuilder.DropColumn(
                name: "SumaNombres",
                table: "Persona");
        }
    }
}
