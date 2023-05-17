using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEnd.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presences_Eleves_Etudiant",
                table: "Presences");

            migrationBuilder.AlterColumn<int>(
                name: "EtudiantId",
                table: "Presences",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "Etudiant",
                table: "Presences",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Presences_Eleves_Etudiant",
                table: "Presences",
                column: "Etudiant",
                principalTable: "Eleves",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Presences_Eleves_Etudiant",
                table: "Presences");

            migrationBuilder.AlterColumn<string>(
                name: "EtudiantId",
                table: "Presences",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Etudiant",
                table: "Presences",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Presences_Eleves_Etudiant",
                table: "Presences",
                column: "Etudiant",
                principalTable: "Eleves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
