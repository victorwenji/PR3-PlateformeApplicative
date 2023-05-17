using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiEnd.Migrations
{
    /// <inheritdoc />
    public partial class Etudiant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eleves_Groupe_Groupe",
                table: "Eleves");

            migrationBuilder.DropForeignKey(
                name: "FK_Eleves_Promotion_Promotion",
                table: "Eleves");

            migrationBuilder.DropIndex(
                name: "IX_Eleves_Groupe",
                table: "Eleves");

            migrationBuilder.DropIndex(
                name: "IX_Eleves_Promotion",
                table: "Eleves");

            migrationBuilder.DropColumn(
                name: "Groupe",
                table: "Eleves");

            migrationBuilder.DropColumn(
                name: "Promotion",
                table: "Eleves");

            migrationBuilder.CreateIndex(
                name: "IX_Eleves_GroupeId",
                table: "Eleves",
                column: "GroupeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eleves_PromotionId",
                table: "Eleves",
                column: "PromotionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eleves_Groupe_GroupeId",
                table: "Eleves",
                column: "GroupeId",
                principalTable: "Groupe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Eleves_Promotion_PromotionId",
                table: "Eleves",
                column: "PromotionId",
                principalTable: "Promotion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eleves_Groupe_GroupeId",
                table: "Eleves");

            migrationBuilder.DropForeignKey(
                name: "FK_Eleves_Promotion_PromotionId",
                table: "Eleves");

            migrationBuilder.DropIndex(
                name: "IX_Eleves_GroupeId",
                table: "Eleves");

            migrationBuilder.DropIndex(
                name: "IX_Eleves_PromotionId",
                table: "Eleves");

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
        }
    }
}
