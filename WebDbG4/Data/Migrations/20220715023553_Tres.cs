using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDbG4.Data.Migrations
{
    public partial class Tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Personas_CiudadId",
                table: "Personas",
                column: "CiudadId");

            migrationBuilder.CreateIndex(
                name: "IX_Ciudades_DptoId",
                table: "Ciudades",
                column: "DptoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciudades_Dptos_DptoId",
                table: "Ciudades",
                column: "DptoId",
                principalTable: "Dptos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Ciudades_CiudadId",
                table: "Personas",
                column: "CiudadId",
                principalTable: "Ciudades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciudades_Dptos_DptoId",
                table: "Ciudades");

            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Ciudades_CiudadId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_CiudadId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Ciudades_DptoId",
                table: "Ciudades");
        }
    }
}
