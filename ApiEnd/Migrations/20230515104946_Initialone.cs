using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEnd.Migrations
{
    /// <inheritdoc />
    public partial class Initialone : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Etudiant",
                table: "Presences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "PromotionId",
                table: "Eleves",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "GroupeId",
                table: "Eleves",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Groupe",
                table: "Eleves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Promotion",
                table: "Eleves",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Presences_Etudiant",
                table: "Presences",
                column: "Etudiant");

            migrationBuilder.CreateIndex(
                name: "IX_Eleves_Groupe",
                table: "Eleves",
                column: "Groupe");

            migrationBuilder.CreateIndex(
                name: "IX_Eleves_Promotion",
                table: "Eleves",
                column: "Promotion");

            migrationBuilder.AddForeignKey(
                name: "FK_Eleves_Groupe_Groupe",
                table: "Eleves",
                column: "Groupe",
                principalTable: "Groupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Eleves_Promotion_Promotion",
                table: "Eleves",
                column: "Promotion",
                principalTable: "Promotion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Presences_Eleves_Etudiant",
                table: "Presences",
                column: "Etudiant",
                principalTable: "Eleves",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eleves_Groupe_Groupe",
                table: "Eleves");

            migrationBuilder.DropForeignKey(
                name: "FK_Eleves_Promotion_Promotion",
                table: "Eleves");

            migrationBuilder.DropForeignKey(
                name: "FK_Presences_Eleves_Etudiant",
                table: "Presences");

            migrationBuilder.DropIndex(
                name: "IX_Presences_Etudiant",
                table: "Presences");

            migrationBuilder.DropIndex(
                name: "IX_Eleves_Groupe",
                table: "Eleves");

            migrationBuilder.DropIndex(
                name: "IX_Eleves_Promotion",
                table: "Eleves");

            migrationBuilder.DropColumn(
                name: "Etudiant",
                table: "Presences");

            migrationBuilder.DropColumn(
                name: "Groupe",
                table: "Eleves");

            migrationBuilder.DropColumn(
                name: "Promotion",
                table: "Eleves");

            migrationBuilder.AlterColumn<string>(
                name: "PromotionId",
                table: "Eleves",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "GroupeId",
                table: "Eleves",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
