using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect3.Migrations
{
    public partial class IdUpdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultatii_Medicamente_MedicamentId",
                table: "Consultatii");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicamente",
                table: "Medicamente");

            migrationBuilder.DropColumn(
                name: "MedicamentId",
                table: "Medicamente");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Medicamente",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicamente",
                table: "Medicamente",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultatii_Medicamente_MedicamentId",
                table: "Consultatii",
                column: "MedicamentId",
                principalTable: "Medicamente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultatii_Medicamente_MedicamentId",
                table: "Consultatii");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medicamente",
                table: "Medicamente");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Medicamente");

            migrationBuilder.AddColumn<int>(
                name: "MedicamentId",
                table: "Medicamente",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medicamente",
                table: "Medicamente",
                column: "MedicamentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultatii_Medicamente_MedicamentId",
                table: "Consultatii",
                column: "MedicamentId",
                principalTable: "Medicamente",
                principalColumn: "MedicamentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
