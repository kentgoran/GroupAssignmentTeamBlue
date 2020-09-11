using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class RealEstateModelChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Operand type clash, datetime2 incompatible with int, so dropping column instead, and add a new
            //migrationBuilder.AlterColumn<int>(
            //    name: "YearBuilt",
            //    table: "RealEstates",
            //    nullable: false,
            //    oldClrType: typeof(DateTime),
            //    oldType: "datetime2");

            migrationBuilder.DropColumn(
                name: "YearBuilt",
                table: "RealEstates");

            migrationBuilder.AddColumn<int>(
                name: "YearBuilt",
                table: "RealEstates",
                nullable: false);

            //End of user-created migration

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice",
                table: "RealEstates",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rent",
                table: "RealEstates",
                type: "money",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RealEstates",
                maxLength: 500,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "RealEstates",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "RealEstateInQuestionId",
                table: "Comments",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_RealEstates_RealEstateInQuestionId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_RealEstateInQuestionId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "RealEstateInQuestionId",
                table: "Comments");

            migrationBuilder.AlterColumn<DateTime>(
                name: "YearBuilt",
                table: "RealEstates",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "SellPrice",
                table: "RealEstates",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<decimal>(
                name: "Rent",
                table: "RealEstates",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "money");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 128);
        }
    }
}
