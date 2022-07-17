using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbG4.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dptos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dptos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dptos");
        }
    }
}
