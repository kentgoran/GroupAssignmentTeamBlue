using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { 1, 0, "68e01f8c-ba04-416e-9e53-dab4c5f2e50d", "bamse@gmail.com", true, true, null, "BAMSE@GMAIL.COM", "BAMSE@GMAIL.COM", "AQAAAAEAACcQAAAAEAR00VgEXuNcTRL9aekKB86ar4F2D+pRmar9AGvUw/Fnxxe531NIpGwsPAi56bxqTg==", null, false, "DRGRSWDQ5C5MZZBZQUWDGHQRW66QI5D6", false, "bamse@gmail.com" },
                    { 2, 0, "b3d90eb5-90d9-4f69-97bd-057f32692f84", "skalman@gmail.com", true, true, null, "SKALMAN@GMAIL.COM", "SKALMAN@GMAIL.COM", "AQAAAAEAACcQAAAAEEOcqQ00ZZaNxwRK5lJGV1RPtl7rGeeMIlietoHd62yeavAR3PsuAGrBI8TWClg/qg==", null, false, "P7HU2IDVNJQEYMGXCN55NQHELVS3TECN", false, "skalman@gmail.com" },
                    { 3, 0, "4c6ba646-058a-4876-ab51-e681e26f74d3", "alfons@gmail.com", true, true, null, "ALFONS@GMAIL.COM", "ALFONS@GMAIL.COM", "AQAAAAEAACcQAAAAEGFDh/g9WmY5IWx5cxkE44yyV5a6ucoFfhUcoe8DmVNIP5Ror9j1dYRxA2zKQMXG0g==", null, false, "K4GFE2ZZLA7BRDI3VWC2M2N2ILHKE6X3", false, "alfons@gmail.com" },
                    { 4, 0, "a638d86b-eac1-4338-90c3-a0f9b42ac60f", "laban@gmail.com", true, true, null, "LABAN@GMAIL.COMm", "LABAN@GMAIL.COM", "AQAAAAEAACcQAAAAEMD595Y3JYWe+nH1AIQhsN6Ft74vry91PDj0/7Mt4ZZoFim856jomEAfq92mo8LHuQ==", null, false, "NW6F2HLUH24CNHBFUNW54LVDZVNG3ALB", false, "laban@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "RealEstates",
                columns: new[] { "Id", "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[,]
                {
                    { 4, "6552 Okuneva Haven, New Golden, Canada", "Verlie Bode, $117 Barton Springs, Scarletttown, French Guiana", new DateTime(1616, 5, 29, 9, 10, 21, 867, DateTimeKind.Unspecified).AddTicks(6542), "Nulla sit qui corporis maiores minima sed.", false, true, 0m, 301994m, "vero", 0, 1, 1616 },
                    { 5, "628 Goodwin Cape, New Dorrismouth, Belarus", "Wilton Mayert, $955 Hagenes Heights, Port Audra, Germany", new DateTime(1742, 1, 30, 16, 57, 59, 687, DateTimeKind.Unspecified).AddTicks(1157), "Animi necessitatibus pariatur repudiandae a vel voluptatem amet atque excepturi.", false, true, 0m, 1620100m, "veritatis", 2, 1, 1742 },
                    { 2, "930 Sonya Bridge, Feilshire, Philippines", "Jody Dietrich, $6304 Howell Roads, East Angusshire, Palestinian Territory", new DateTime(1649, 1, 23, 3, 0, 38, 110, DateTimeKind.Unspecified).AddTicks(377), "Velit eaque sed quidem aut doloribus aut.", true, false, 4866m, 0m, "quo", 2, 2, 1649 },
                    { 3, "62059 Hilpert Brooks, Lake Haylie, Turkmenistan", "Nico Hauck, $80258 Cole Turnpike, South Dellview, Andorra", new DateTime(1702, 11, 23, 20, 53, 52, 222, DateTimeKind.Unspecified).AddTicks(9110), "Sint consequuntur provident est aliquid deleniti aut voluptatibus vitae.", true, false, 9329m, 0m, "sint", 3, 2, 1702 },
                    { 1, "91073 Feest Spurs, West Wilfridville, Senegal", "Laurine Carroll, $1908 Antone Manors, South Araceli, Sri Lanka", new DateTime(1644, 12, 23, 14, 5, 42, 386, DateTimeKind.Unspecified).AddTicks(4720), "Voluptatem fuga laudantium non ratione.", false, true, 0m, 1096466m, "laboriosam", 0, 4, 1644 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
