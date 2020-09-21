using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class AddedPicturesToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pictures",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(nullable: false),
                    RealEstateId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pictures_RealEstates_RealEstateId",
                        column: x => x.RealEstateId,
                        principalTable: "RealEstates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 10, 15, 49, 468, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 23, 4, 30, 651, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 21, 14, 23, 362, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 16, 17, 16, 287, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 23, 41, 52, 266, DateTimeKind.Local).AddTicks(2610));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 17, 14, 34, 189, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 2, 55, 4, 333, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 10, 40, 13, 476, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 23, 20, 50, 944, DateTimeKind.Local).AddTicks(5005));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 15, 35, 27, 352, DateTimeKind.Local).AddTicks(5597));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 3, 47, 4, 16, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 2, 9, 41, 656, DateTimeKind.Local).AddTicks(6577));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 4, 25, 42, 361, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 11, 54, 30, 553, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 16, 13, 56, 777, DateTimeKind.Local).AddTicks(4764));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 2, 19, 15, 586, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 22, 14, 47, 483, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 0, 50, 50, 989, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 11, 2, 16, 601, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 12, 48, 55, 771, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 0, 41, 7, 319, DateTimeKind.Local).AddTicks(6812));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 12, 31, 23, 193, DateTimeKind.Local).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 20, 49, 31, 137, DateTimeKind.Local).AddTicks(8430));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 2, 36, 39, 756, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 3, 47, 47, 699, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 22, 40, 45, 412, DateTimeKind.Local).AddTicks(1353));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 3, 6, 8, 69, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 3, 57, 43, 947, DateTimeKind.Local).AddTicks(9427));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 11, 51, 49, 158, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 7, 17, 5, 565, DateTimeKind.Local).AddTicks(3124));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 22, 16, 35, 396, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 13, 26, 18, 179, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 13, 8, 54, 513, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 21, 53, 51, 749, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 18, 24, 46, 346, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 23, 49, 28, 258, DateTimeKind.Local).AddTicks(5765));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 3, 2, 21, 408, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 21, 38, 39, 877, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 21, 24, 57, 236, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 1, 46, 55, 625, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 17, 21, 48, 511, DateTimeKind.Local).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 11, 32, 38, 23, DateTimeKind.Local).AddTicks(9918));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 16, 23, 43, 976, DateTimeKind.Local).AddTicks(1382));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 7, 12, 36, 615, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 17, 56, 47, 494, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 23, 56, 34, 380, DateTimeKind.Local).AddTicks(5503));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 2, 45, 8, 349, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 1, 8, 42, 82, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 21, 33, 36, 462, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 21, 52, 16, 224, DateTimeKind.Local).AddTicks(7598));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 8, 43, 21, 366, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 10, 51, 16, 303, DateTimeKind.Local).AddTicks(5160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 18, 23, 19, 653, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 17, 4, 40, 981, DateTimeKind.Local).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 5, 48, 52, 231, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 5, 51, 9, 937, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 9, 52, 38, 664, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 7, 24, 44, 943, DateTimeKind.Local).AddTicks(3890));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 21, 1, 43, 10, 298, DateTimeKind.Local).AddTicks(9256));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 20, 8, 45, 37, 691, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.CreateIndex(
                name: "IX_Pictures_RealEstateId",
                table: "Pictures",
                column: "RealEstateId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pictures");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 15, 30, 52, 790, DateTimeKind.Local).AddTicks(5600));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 4, 19, 33, 974, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 2, 29, 26, 685, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 21, 32, 19, 610, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 4, 56, 55, 588, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 22, 29, 37, 511, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 8, 10, 7, 656, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 15, 55, 16, 798, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 4, 35, 54, 266, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 20, 50, 30, 674, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 9, 2, 7, 338, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 7, 24, 44, 978, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 9, 40, 45, 683, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 17, 9, 33, 875, DateTimeKind.Local).AddTicks(4717));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 21, 29, 0, 99, DateTimeKind.Local).AddTicks(7622));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 7, 34, 18, 909, DateTimeKind.Local).AddTicks(1100));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 3, 29, 50, 805, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 6, 5, 54, 312, DateTimeKind.Local).AddTicks(573));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 16, 17, 19, 923, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 18, 3, 59, 93, DateTimeKind.Local).AddTicks(5967));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 5, 56, 10, 641, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 17, 46, 26, 515, DateTimeKind.Local).AddTicks(7277));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 2, 4, 34, 460, DateTimeKind.Local).AddTicks(1320));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 7, 51, 43, 78, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 9, 2, 51, 21, DateTimeKind.Local).AddTicks(5093));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 3, 55, 48, 734, DateTimeKind.Local).AddTicks(4236));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 8, 21, 11, 392, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 9, 12, 47, 270, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 17, 6, 52, 480, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 12, 32, 8, 887, DateTimeKind.Local).AddTicks(5992));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 3, 31, 38, 718, DateTimeKind.Local).AddTicks(8924));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 18, 41, 21, 501, DateTimeKind.Local).AddTicks(8394));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 18, 23, 57, 836, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 3, 8, 55, 71, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 23, 39, 49, 668, DateTimeKind.Local).AddTicks(4523));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 5, 4, 31, 580, DateTimeKind.Local).AddTicks(8581));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 8, 17, 24, 730, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 2, 53, 43, 199, DateTimeKind.Local).AddTicks(8986));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 2, 40, 0, 558, DateTimeKind.Local).AddTicks(6994));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 7, 1, 58, 947, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 22, 36, 51, 833, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 16, 47, 41, 346, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 21, 38, 47, 298, DateTimeKind.Local).AddTicks(4152));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 12, 27, 39, 937, DateTimeKind.Local).AddTicks(4344));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 23, 11, 50, 816, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 5, 11, 37, 702, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 8, 0, 11, 672, DateTimeKind.Local).AddTicks(1222));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 6, 23, 45, 404, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 2, 48, 39, 784, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 3, 7, 19, 547, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 13, 58, 24, 688, DateTimeKind.Local).AddTicks(5003));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 16, 6, 19, 625, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 23, 38, 22, 975, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 22, 19, 44, 303, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 11, 3, 55, 553, DateTimeKind.Local).AddTicks(5430));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 11, 6, 13, 259, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 15, 7, 41, 987, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 12, 39, 48, 265, DateTimeKind.Local).AddTicks(6672));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 18, 6, 58, 13, 621, DateTimeKind.Local).AddTicks(2033));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 17, 14, 0, 41, 14, DateTimeKind.Local).AddTicks(92));
        }
    }
}
