using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class AddedSeedData : Migration
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
                table: "Ratings",
                columns: new[] { "Id", "RatedUserId", "RatingUserId", "Score" },
                values: new object[,]
                {
                    { 1, 1, 2, 4 },
                    { 2, 3, 1, 1 }
                });

            migrationBuilder.InsertData(
                table: "RealEstates",
                columns: new[] { "Id", "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[,]
                {
                    { 2, "Kulls väg 23", "112", new DateTime(2020, 9, 13, 12, 28, 30, 0, DateTimeKind.Unspecified), "This is a test", false, true, null, 1795000m, "Haiii", 0, 1, 2001 },
                    { 1, "Kulls väg 8", "0709-662239", new DateTime(2020, 9, 14, 18, 15, 30, 0, DateTimeKind.Unspecified), "This is a test", true, false, 200m, null, "Sum", 0, 2, 2019 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "ParentCommentId", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { 1, "This apartment is crap...", null, 1, new DateTime(2020, 9, 16, 17, 9, 12, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "ParentCommentId", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { 2, "You are just mad because I didn't let you rent it...", null, 1, new DateTime(2020, 9, 16, 17, 14, 30, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "ParentCommentId", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { 3, "Woah, *Grabbing popcorn*", null, 1, new DateTime(2020, 9, 16, 17, 30, 29, 0, DateTimeKind.Unspecified), 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
