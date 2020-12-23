using Microsoft.EntityFrameworkCore.Migrations;

namespace Proiect3.Migrations
{
    public partial class FinalIpUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultatii_Pacients_PacientId",
                table: "Consultatii");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicPacients_Pacients_PacientId",
                table: "MedicPacients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacients",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "PacientId",
                table: "Pacients");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Pacients",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacients",
                table: "Pacients",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultatii_Pacients_PacientId",
                table: "Consultatii",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicPacients_Pacients_PacientId",
                table: "MedicPacients",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultatii_Pacients_PacientId",
                table: "Consultatii");

            migrationBuilder.DropForeignKey(
                name: "FK_MedicPacients_Pacients_PacientId",
                table: "MedicPacients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pacients",
                table: "Pacients");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Pacients");

            migrationBuilder.AddColumn<int>(
                name: "PacientId",
                table: "Pacients",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pacients",
                table: "Pacients",
                column: "PacientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultatii_Pacients_PacientId",
                table: "Consultatii",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "PacientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MedicPacients_Pacients_PacientId",
                table: "MedicPacients",
                column: "PacientId",
                principalTable: "Pacients",
                principalColumn: "PacientId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
