using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect3.Migrations
{
    public partial class IdUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicPacients_Medics_MedicId",
                table: "MedicPacients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medics",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "MedicId",
                table: "Medics");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Medics",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medics",
                table: "Medics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicPacients_Medics_MedicId",
                table: "MedicPacients",
                column: "MedicId",
                principalTable: "Medics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MedicPacients_Medics_MedicId",
                table: "MedicPacients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Medics",
                table: "Medics");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Medics");

            migrationBuilder.AddColumn<int>(
                name: "MedicId",
                table: "Medics",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Medics",
                table: "Medics",
                column: "MedicId");

            migrationBuilder.AddForeignKey(
                name: "FK_MedicPacients_Medics_MedicId",
                table: "MedicPacients",
                column: "MedicId",
                principalTable: "Medics",
                principalColumn: "MedicId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
