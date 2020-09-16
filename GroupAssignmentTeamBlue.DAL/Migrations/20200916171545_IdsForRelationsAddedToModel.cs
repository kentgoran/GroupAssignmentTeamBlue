using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class IdsForRelationsAddedToModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_RealEstates_RealEstateInQuestionId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_RealEstateInQuestionId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "RealEstateInQuestionId",
                table: "Comments");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice",
                table: "RealEstates",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rent",
                table: "RealEstates",
                type: "money",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AddColumn<int>(
                name: "RealEstateId",
                table: "Comments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RealEstateId",
                table: "Comments",
                column: "RealEstateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_RealEstates_RealEstateId",
                table: "Comments",
                column: "RealEstateId",
                principalTable: "RealEstates",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_RealEstates_RealEstateId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_RealEstateId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "RealEstateId",
                table: "Comments");

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice",
                table: "RealEstates",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rent",
                table: "RealEstates",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RealEstateInQuestionId",
                table: "Comments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_RealEstateInQuestionId",
                table: "Comments",
                column: "RealEstateInQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_RealEstates_RealEstateInQuestionId",
                table: "Comments",
                column: "RealEstateInQuestionId",
                principalTable: "RealEstates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
