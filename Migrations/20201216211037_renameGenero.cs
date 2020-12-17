using Microsoft.EntityFrameworkCore.Migrations;

namespace toDosMvc.Migrations
{
    public partial class renameGenero : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sexo",
                table: "Usuarios",
                newName: "Genero");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Genero",
                table: "Usuarios",
                newName: "sexo");
        }
    }
}
