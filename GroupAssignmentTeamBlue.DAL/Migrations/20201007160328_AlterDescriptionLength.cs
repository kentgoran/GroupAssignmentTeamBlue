using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class AlterDescriptionLength : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RealEstates",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 5, 1, 32, 753, DateTimeKind.Local).AddTicks(5188));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 17, 7, 26, 496, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 21, 23, 12, 567, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 23, 9, 51, 737, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 11, 2, 3, 285, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 22, 52, 19, 159, DateTimeKind.Local).AddTicks(3308));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 7, 10, 27, 103, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 12, 57, 35, 722, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 14, 8, 43, 665, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 9, 1, 41, 378, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 13, 27, 4, 35, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 14, 18, 39, 913, DateTimeKind.Local).AddTicks(8414));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 22, 12, 45, 124, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 17, 38, 1, 531, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 8, 37, 31, 362, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 23, 47, 14, 145, DateTimeKind.Local).AddTicks(4577));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 23, 29, 50, 479, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 8, 14, 47, 715, DateTimeKind.Local).AddTicks(4038));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 4, 45, 42, 312, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 10, 10, 24, 224, DateTimeKind.Local).AddTicks(4919));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 13, 23, 17, 374, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 7, 59, 35, 843, DateTimeKind.Local).AddTicks(5321));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 7, 45, 53, 202, DateTimeKind.Local).AddTicks(3347));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 12, 7, 51, 590, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 3, 42, 44, 477, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 21, 53, 33, 989, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 2, 44, 39, 942, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 17, 33, 32, 581, DateTimeKind.Local).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 4, 17, 43, 460, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 10, 17, 30, 346, DateTimeKind.Local).AddTicks(4781));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 13, 6, 4, 315, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 11, 29, 38, 47, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 7, 54, 32, 428, DateTimeKind.Local).AddTicks(3863));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 8, 13, 12, 190, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 19, 4, 17, 332, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 21, 12, 12, 269, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 4, 44, 15, 619, DateTimeKind.Local).AddTicks(5953));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 3, 25, 36, 947, DateTimeKind.Local).AddTicks(3054));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 16, 9, 48, 197, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 16, 12, 5, 903, DateTimeKind.Local).AddTicks(48));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 20, 13, 34, 630, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 17, 45, 40, 909, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 12, 4, 6, 264, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 19, 6, 33, 657, DateTimeKind.Local).AddTicks(6804));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 9, 10, 22, 493, DateTimeKind.Local).AddTicks(1375));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 23, 8, 22, 188, DateTimeKind.Local).AddTicks(3791));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 7, 32, 20, 899, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 14, 37, 14, 641, DateTimeKind.Local).AddTicks(7400));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 20, 57, 11, 952, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 22, 13, 18, 91, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 10, 47, 15, 8, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 12, 2, 59, 974, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 19, 24, 6, 492, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 0, 11, 29, 68, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 17, 31, 53, 33, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 13, 21, 43, 213, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 9, 53, 39, 495, DateTimeKind.Local).AddTicks(137));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 21, 57, 27, 470, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 7, 12, 39, 8, 749, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                column: "TimeOfCreation",
                value: new DateTime(2020, 10, 6, 19, 34, 37, 367, DateTimeKind.Local).AddTicks(2126));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "RealEstates",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 1, 33, 10, 484, DateTimeKind.Local).AddTicks(2246));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 13, 39, 4, 227, DateTimeKind.Local).AddTicks(4539));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 17, 54, 50, 298, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 19, 41, 29, 467, DateTimeKind.Local).AddTicks(8132));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 7, 33, 41, 16, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 19, 23, 56, 889, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 3, 42, 4, 834, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 9, 29, 13, 452, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 10, 40, 21, 395, DateTimeKind.Local).AddTicks(7307));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 5, 33, 19, 108, DateTimeKind.Local).AddTicks(6456));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 9, 58, 41, 766, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 10, 50, 17, 644, DateTimeKind.Local).AddTicks(4506));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 18, 44, 22, 855, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 14, 9, 39, 261, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 5, 9, 9, 93, DateTimeKind.Local).AddTicks(1186));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 20, 18, 51, 876, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 20, 1, 28, 210, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 4, 46, 25, 446, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 1, 17, 20, 42, DateTimeKind.Local).AddTicks(6819));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 6, 42, 1, 955, DateTimeKind.Local).AddTicks(883));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 9, 54, 55, 104, DateTimeKind.Local).AddTicks(6771));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 4, 31, 13, 574, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 4, 17, 30, 932, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 8, 39, 29, 321, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 0, 14, 22, 208, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 18, 25, 11, 720, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 23, 16, 17, 672, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 14, 5, 10, 311, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 0, 49, 21, 190, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 6, 49, 8, 77, DateTimeKind.Local).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 9, 37, 42, 46, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 8, 1, 15, 778, DateTimeKind.Local).AddTicks(5367));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 4, 26, 10, 158, DateTimeKind.Local).AddTicks(9770));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 4, 44, 49, 921, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 15, 35, 55, 62, DateTimeKind.Local).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 17, 43, 50, 0, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 1, 15, 53, 350, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 23, 57, 14, 677, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 12, 41, 25, 927, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 12, 43, 43, 633, DateTimeKind.Local).AddTicks(5888));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 16, 45, 12, 361, DateTimeKind.Local).AddTicks(4116));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 14, 17, 18, 639, DateTimeKind.Local).AddTicks(9206));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 8, 35, 43, 995, DateTimeKind.Local).AddTicks(4578));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 15, 38, 11, 388, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 5, 42, 0, 223, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 19, 39, 59, 918, DateTimeKind.Local).AddTicks(9568));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 4, 3, 58, 630, DateTimeKind.Local).AddTicks(4359));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 11, 8, 52, 372, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 17, 28, 49, 683, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 18, 44, 55, 822, DateTimeKind.Local).AddTicks(5135));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 7, 18, 52, 738, DateTimeKind.Local).AddTicks(9499));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 8, 34, 37, 705, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 15, 55, 44, 222, DateTimeKind.Local).AddTicks(8263));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 20, 43, 6, 799, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 14, 3, 30, 764, DateTimeKind.Local).AddTicks(4069));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 9, 53, 20, 943, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 6, 25, 17, 225, DateTimeKind.Local).AddTicks(5804));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 18, 29, 5, 201, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 30, 9, 10, 46, 479, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                column: "TimeOfCreation",
                value: new DateTime(2020, 9, 29, 16, 6, 15, 97, DateTimeKind.Local).AddTicks(7725));
        }
    }
}
