using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class ChangedAddressAndContactToStrings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RealEstates_Addresses_AddressId",
                table: "RealEstates");

            migrationBuilder.DropForeignKey(
                name: "FK_RealEstates_Contacts_ContactId",
                table: "RealEstates");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropIndex(
                name: "IX_RealEstates_AddressId",
                table: "RealEstates");

            migrationBuilder.DropIndex(
                name: "IX_RealEstates_ContactId",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "RealEstates");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "RealEstates",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "RealEstates",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "Contact",
                table: "RealEstates");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "RealEstates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "RealEstates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    StateProvince = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StreetNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RealEstates_AddressId",
                table: "RealEstates",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_RealEstates_ContactId",
                table: "RealEstates",
                column: "ContactId");

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstates_Addresses_AddressId",
                table: "RealEstates",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RealEstates_Contacts_ContactId",
                table: "RealEstates",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
