using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class SeedDeta : Migration
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
                    { 2, 1, 1, 2 },
                    { 24, 4, 4, 2 },
                    { 18, 4, 4, 1 },
                    { 15, 4, 4, 4 },
                    { 11, 4, 4, 3 },
                    { 3, 4, 4, 1 },
                    { 6, 3, 3, 1 },
                    { 8, 3, 3, 3 },
                    { 13, 3, 3, 2 },
                    { 19, 3, 3, 2 },
                    { 20, 3, 3, 1 },
                    { 22, 3, 3, 3 },
                    { 25, 3, 3, 5 },
                    { 28, 3, 3, 3 },
                    { 30, 3, 3, 3 },
                    { 33, 3, 3, 3 },
                    { 34, 3, 3, 2 },
                    { 36, 3, 3, 1 },
                    { 26, 4, 4, 4 },
                    { 39, 3, 3, 3 },
                    { 31, 2, 2, 4 },
                    { 17, 2, 2, 5 },
                    { 5, 1, 1, 5 },
                    { 7, 1, 1, 1 },
                    { 12, 1, 1, 4 },
                    { 16, 1, 1, 3 },
                    { 21, 1, 1, 3 },
                    { 23, 1, 1, 4 },
                    { 27, 1, 1, 1 },
                    { 29, 2, 2, 1 },
                    { 37, 4, 4, 5 },
                    { 38, 4, 4, 2 },
                    { 32, 4, 4, 1 },
                    { 1, 2, 2, 4 },
                    { 4, 2, 2, 4 },
                    { 9, 2, 2, 5 },
                    { 10, 2, 2, 3 },
                    { 14, 2, 2, 4 },
                    { 35, 4, 4, 2 },
                    { 40, 3, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "RealEstates",
                columns: new[] { "Id", "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[,]
                {
                    { 11, "65136 Evangeline Station, Friesentown, Palau", "Jocelyn Monahan, $0460 Moen Keys, East Jaimestad, Burkina Faso", new DateTime(1606, 11, 8, 22, 40, 36, 380, DateTimeKind.Unspecified).AddTicks(2113), "Modi reiciendis praesentium aut incidunt cumque placeat.", true, false, 7981m, 0m, "facilis", 0, 3, 1606 },
                    { 1, "91073 Feest Spurs, West Wilfridville, Senegal", "Laurine Carroll, $1908 Antone Manors, South Araceli, Sri Lanka", new DateTime(1644, 12, 23, 14, 5, 42, 386, DateTimeKind.Unspecified).AddTicks(4720), "Voluptatem fuga laudantium non ratione.", false, true, 0m, 1096466m, "laboriosam", 0, 4, 1644 },
                    { 8, "2243 Myrtle Square, South Savannahmouth, Saint Barthelemy", "Oswaldo Rodriguez, $1164 Dante Plaza, Alfhaven, Maldives", new DateTime(1762, 12, 13, 0, 28, 4, 514, DateTimeKind.Unspecified).AddTicks(6217), "Corporis eveniet nostrum ut officia atque blanditiis possimus.", false, true, 0m, 1504483m, "vel", 3, 4, 1762 },
                    { 12, "75762 Cormier Bridge, Graysonchester, Hong Kong", "Cristopher Marks, $954 Ena Ports, Shieldstown, Afghanistan", new DateTime(1939, 11, 16, 13, 27, 43, 678, DateTimeKind.Unspecified).AddTicks(3721), "Et provident nobis mollitia consequatur et.", true, false, 10467m, 0m, "eius", 2, 3, 1939 },
                    { 19, "07936 Carlee Ford, Ziemeshire, Svalbard & Jan Mayen Islands", "Wade Hackett, $5238 Marisa Lakes, Harveyhaven, Niue", new DateTime(1769, 6, 30, 18, 0, 26, 696, DateTimeKind.Unspecified).AddTicks(6466), "Est ea quis delectus delectus autem quos id occaecati repellendus.", false, true, 0m, 2799231m, "ex", 3, 2, 1769 },
                    { 18, "24341 Vilma Villages, Ferryton, Croatia", "Nicholas Padberg, $78078 Grady Corners, Annettaton, Ukraine", new DateTime(1732, 1, 13, 11, 1, 40, 240, DateTimeKind.Unspecified).AddTicks(7676), "Minima natus sunt facilis.", true, false, 9966m, 0m, "aperiam", 0, 2, 1732 },
                    { 16, "8172 Greenholt Crescent, Alannaville, Norfolk Island", "Brandi Pfannerstill, $60031 Purdy Well, Lake Kiel, Equatorial Guinea", new DateTime(1846, 5, 16, 13, 55, 26, 780, DateTimeKind.Unspecified).AddTicks(9997), "Voluptas dicta mollitia.", true, false, 6655m, 0m, "dolore", 1, 2, 1846 },
                    { 14, "305 Loren Orchard, Emmaleemouth, Sierra Leone", "Travis Walsh, $300 Nolan Island, East Frances, Eritrea", new DateTime(1660, 3, 24, 18, 17, 44, 236, DateTimeKind.Unspecified).AddTicks(9860), "Deleniti occaecati ullam illum aut accusamus blanditiis voluptas.", true, false, 5590m, 0m, "nostrum", 2, 2, 1660 },
                    { 7, "918 Lebsack Highway, Port Myronborough, Georgia", "Lyla Terry, $5500 Nick Shores, Briaside, Spain", new DateTime(1937, 1, 18, 22, 18, 22, 769, DateTimeKind.Unspecified).AddTicks(174), "Temporibus minima id atque voluptatem repellat quos consequatur facilis tenetur.", false, true, 0m, 2463133m, "nostrum", 3, 2, 1937 },
                    { 6, "57264 Jared Summit, East Elsieville, Yemen", "Elfrieda Rowe, $0758 Hills Ferry, Marquardtside, Italy", new DateTime(1701, 12, 22, 1, 58, 30, 272, DateTimeKind.Unspecified).AddTicks(5613), "Animi illum id.", true, false, 7236m, 0m, "optio", 2, 2, 1701 },
                    { 3, "62059 Hilpert Brooks, Lake Haylie, Turkmenistan", "Nico Hauck, $80258 Cole Turnpike, South Dellview, Andorra", new DateTime(1702, 11, 23, 20, 53, 52, 222, DateTimeKind.Unspecified).AddTicks(9110), "Sint consequuntur provident est aliquid deleniti aut voluptatibus vitae.", true, false, 9329m, 0m, "sint", 3, 2, 1702 },
                    { 2, "930 Sonya Bridge, Feilshire, Philippines", "Jody Dietrich, $6304 Howell Roads, East Angusshire, Palestinian Territory", new DateTime(1649, 1, 23, 3, 0, 38, 110, DateTimeKind.Unspecified).AddTicks(377), "Velit eaque sed quidem aut doloribus aut.", true, false, 4866m, 0m, "quo", 2, 2, 1649 },
                    { 17, "7069 Hansen Rapid, South Anjalichester, Czech Republic", "Kellen Vandervort, $988 Maddison Locks, Ellisburgh, Ghana", new DateTime(1740, 6, 8, 21, 48, 17, 663, DateTimeKind.Unspecified).AddTicks(2573), "Optio placeat dolorem incidunt at.", true, false, 7356m, 0m, "veritatis", 2, 1, 1740 },
                    { 15, "919 Alexandria Camp, Sawaynfurt, Uganda", "Marshall Kunze, $114 Bianka Fork, Port Judebury, Guatemala", new DateTime(1775, 1, 11, 4, 58, 47, 660, DateTimeKind.Unspecified).AddTicks(8044), "Et qui laboriosam numquam hic id nemo.", false, true, 0m, 1449966m, "deserunt", 2, 1, 1775 },
                    { 13, "0486 Wiegand Corners, West Meggie, Japan", "Charlie Jones, $00590 King Ways, Port Leonardburgh, Falkland Islands (Malvinas)", new DateTime(1842, 3, 22, 18, 22, 47, 197, DateTimeKind.Unspecified).AddTicks(7649), "Est odio sunt rerum nihil voluptatem fugit voluptas accusantium aliquam.", false, true, 0m, 2967411m, "earum", 3, 1, 1842 },
                    { 9, "4179 Hermiston Canyon, North Houstonbury, Republic of Korea", "Mabel Padberg, $72207 Dominic Brooks, Morissettemouth, Eritrea", new DateTime(1884, 8, 15, 16, 41, 41, 892, DateTimeKind.Unspecified).AddTicks(3384), "Eos dolor necessitatibus omnis.", false, true, 0m, 646934m, "odio", 2, 1, 1884 },
                    { 5, "628 Goodwin Cape, New Dorrismouth, Belarus", "Wilton Mayert, $955 Hagenes Heights, Port Audra, Germany", new DateTime(1742, 1, 30, 16, 57, 59, 687, DateTimeKind.Unspecified).AddTicks(1157), "Animi necessitatibus pariatur repudiandae a vel voluptatem amet atque excepturi.", false, true, 0m, 1620100m, "veritatis", 2, 1, 1742 },
                    { 4, "6552 Okuneva Haven, New Golden, Canada", "Verlie Bode, $117 Barton Springs, Scarletttown, French Guiana", new DateTime(1616, 5, 29, 9, 10, 21, 867, DateTimeKind.Unspecified).AddTicks(6542), "Nulla sit qui corporis maiores minima sed.", false, true, 0m, 301994m, "vero", 0, 1, 1616 },
                    { 10, "1538 Hartmann Burgs, Jeffrymouth, Finland", "Reta Kilback, $888 Johnston Hill, Port Cleta, Bangladesh", new DateTime(1721, 4, 6, 23, 51, 46, 885, DateTimeKind.Unspecified).AddTicks(6356), "Doloribus vitae quaerat.", true, false, 6150m, 0m, "non", 3, 4, 1721 },
                    { 20, "9195 Harris Roads, Rauview, Holy See (Vatican City State)", "Savanna Brakus, $532 Gerhard Island, Port Rahul, Myanmar", new DateTime(1858, 3, 30, 10, 57, 49, 18, DateTimeKind.Unspecified).AddTicks(3645), "Sint natus delectus alias eveniet molestias aspernatur eligendi illum.", true, false, 8703m, 0m, "ut", 0, 4, 1858 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "ParentCommentId", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[,]
                {
                    { 15, "Est numquam adipisci voluptatibus fuga officia soluta.", null, 4, new DateTime(2020, 9, 17, 21, 29, 0, 99, DateTimeKind.Local).AddTicks(7622), 4 },
                    { 31, "Consequatur nam recusandae tenetur odit nihil ut.", null, 7, new DateTime(2020, 9, 18, 3, 31, 38, 718, DateTimeKind.Local).AddTicks(8924), 4 },
                    { 53, "Omnis voluptatum nihil officiis rerum repellat facilis dignissimos quia.", null, 7, new DateTime(2020, 9, 17, 23, 38, 22, 975, DateTimeKind.Local).AddTicks(9377), 2 },
                    { 60, "Corrupti dolores assumenda dolores.", null, 7, new DateTime(2020, 9, 17, 14, 0, 41, 14, DateTimeKind.Local).AddTicks(92), 3 },
                    { 41, "Vel tempora similique voluptas minus pariatur consectetur.", null, 14, new DateTime(2020, 9, 17, 22, 36, 51, 833, DateTimeKind.Local).AddTicks(9666), 4 },
                    { 2, "Fugiat assumenda ut repudiandae est tenetur.", null, 16, new DateTime(2020, 9, 18, 4, 19, 33, 974, DateTimeKind.Local).AddTicks(1772), 2 },
                    { 21, "Quae corrupti distinctio.", null, 16, new DateTime(2020, 9, 18, 5, 56, 10, 641, DateTimeKind.Local).AddTicks(9676), 4 },
                    { 40, "Quibusdam voluptas eaque impedit praesentium.", null, 16, new DateTime(2020, 9, 18, 7, 1, 58, 947, DateTimeKind.Local).AddTicks(3212), 4 },
                    { 23, "Et nulla corrupti.", null, 18, new DateTime(2020, 9, 18, 2, 4, 34, 460, DateTimeKind.Local).AddTicks(1320), 3 },
                    { 32, "Ducimus qui quos quia laboriosam.", null, 19, new DateTime(2020, 9, 17, 18, 41, 21, 501, DateTimeKind.Local).AddTicks(8394), 3 },
                    { 1, "Tempore aut odio sed similique pariatur neque aut in tenetur.", null, 11, new DateTime(2020, 9, 17, 15, 30, 52, 790, DateTimeKind.Local).AddTicks(5600), 4 },
                    { 3, "Alias non eius.", null, 11, new DateTime(2020, 9, 18, 2, 29, 26, 685, DateTimeKind.Local).AddTicks(1842), 1 },
                    { 5, "Qui voluptatum omnis est voluptatem quo accusamus est nulla.", null, 11, new DateTime(2020, 9, 18, 4, 56, 55, 588, DateTimeKind.Local).AddTicks(5565), 2 },
                    { 11, "Illum voluptatem eveniet illum laudantium ad qui ipsa eius maiores.", null, 7, new DateTime(2020, 9, 18, 9, 2, 7, 338, DateTimeKind.Local).AddTicks(5661), 2 },
                    { 20, "Voluptas voluptates omnis inventore nostrum facilis eveniet et.", null, 11, new DateTime(2020, 9, 17, 18, 3, 59, 93, DateTimeKind.Local).AddTicks(5967), 1 },
                    { 43, "Molestiae error quia enim reprehenderit aliquam.", null, 12, new DateTime(2020, 9, 17, 21, 38, 47, 298, DateTimeKind.Local).AddTicks(4152), 1 },
                    { 58, "Hic laudantium nam laborum officia ad nesciunt saepe illum provident.", null, 12, new DateTime(2020, 9, 18, 12, 39, 48, 265, DateTimeKind.Local).AddTicks(6672), 4 },
                    { 7, "Aliquid consequatur enim molestias quo porro cupiditate nihil.", null, 8, new DateTime(2020, 9, 18, 8, 10, 7, 656, DateTimeKind.Local).AddTicks(2105), 2 },
                    { 9, "Eos nulla tempore et ea cupiditate deleniti dolores voluptatem.", null, 8, new DateTime(2020, 9, 18, 4, 35, 54, 266, DateTimeKind.Local).AddTicks(7875), 1 },
                    { 13, "Temporibus nihil facere consequatur et cum inventore amet.", null, 8, new DateTime(2020, 9, 18, 9, 40, 45, 683, DateTimeKind.Local).AddTicks(6753), 3 },
                    { 27, "Voluptatem ducimus qui accusantium fugiat adipisci.", null, 8, new DateTime(2020, 9, 18, 8, 21, 11, 392, DateTimeKind.Local).AddTicks(1846), 2 },
                    { 55, "A quia suscipit voluptate consequatur veniam veniam.", null, 8, new DateTime(2020, 9, 18, 11, 3, 55, 553, DateTimeKind.Local).AddTicks(5430), 4 },
                    { 19, "Ut commodi voluptate.", null, 10, new DateTime(2020, 9, 17, 16, 17, 19, 923, DateTimeKind.Local).AddTicks(9955), 1 },
                    { 36, "Et qui exercitationem omnis ab consequuntur nihil optio quia.", null, 10, new DateTime(2020, 9, 18, 5, 4, 31, 580, DateTimeKind.Local).AddTicks(8581), 4 },
                    { 54, "Dolores assumenda eos perferendis iusto aut.", null, 10, new DateTime(2020, 9, 17, 22, 19, 44, 303, DateTimeKind.Local).AddTicks(6461), 2 },
                    { 10, "Quia aliquam at corporis.", null, 20, new DateTime(2020, 9, 17, 20, 50, 30, 674, DateTimeKind.Local).AddTicks(8496), 2 },
                    { 24, "Atque natus asperiores.", null, 20, new DateTime(2020, 9, 18, 7, 51, 43, 78, DateTimeKind.Local).AddTicks(7720), 2 },
                    { 33, "Eos libero nisi nam possimus hic in eos dolores.", null, 11, new DateTime(2020, 9, 17, 18, 23, 57, 836, DateTimeKind.Local).AddTicks(888), 2 },
                    { 37, "Fugiat ea aliquid magnam at.", null, 6, new DateTime(2020, 9, 18, 8, 17, 24, 730, DateTimeKind.Local).AddTicks(4493), 1 },
                    { 29, "Quas inventore pariatur.", null, 6, new DateTime(2020, 9, 17, 17, 6, 52, 480, DateTimeKind.Local).AddTicks(9536), 1 },
                    { 12, "Distinctio dolorem sunt sed sit autem.", null, 6, new DateTime(2020, 9, 18, 7, 24, 44, 978, DateTimeKind.Local).AddTicks(9479), 3 },
                    { 35, "Accusamus fugit consequatur itaque.", null, 4, new DateTime(2020, 9, 17, 23, 39, 49, 668, DateTimeKind.Local).AddTicks(4523), 4 },
                    { 46, "Quo ipsam quisquam quo dolores nostrum sunt.", null, 4, new DateTime(2020, 9, 18, 5, 11, 37, 702, DateTimeKind.Local).AddTicks(8329), 2 },
                    { 49, "Quae sed quia rerum.", null, 4, new DateTime(2020, 9, 18, 2, 48, 39, 784, DateTimeKind.Local).AddTicks(7316), 2 },
                    { 39, "Enim assumenda sed vero nihil aut exercitationem.", null, 5, new DateTime(2020, 9, 18, 2, 40, 0, 558, DateTimeKind.Local).AddTicks(6994), 4 },
                    { 52, "Repellendus repellat alias expedita et.", null, 5, new DateTime(2020, 9, 17, 16, 6, 19, 625, DateTimeKind.Local).AddTicks(7963), 4 },
                    { 16, "Cupiditate vel perspiciatis perspiciatis non aspernatur non placeat consequatur.", null, 9, new DateTime(2020, 9, 18, 7, 34, 18, 909, DateTimeKind.Local).AddTicks(1100), 1 },
                    { 34, "Quisquam praesentium sunt.", null, 9, new DateTime(2020, 9, 18, 3, 8, 55, 71, DateTimeKind.Local).AddTicks(7826), 2 },
                    { 38, "Neque delectus qui velit recusandae voluptatem vero ea.", null, 9, new DateTime(2020, 9, 18, 2, 53, 43, 199, DateTimeKind.Local).AddTicks(8986), 1 },
                    { 42, "Voluptas nesciunt placeat.", null, 9, new DateTime(2020, 9, 17, 16, 47, 41, 346, DateTimeKind.Local).AddTicks(2691), 4 },
                    { 47, "Cumque consequatur sint odio.", null, 9, new DateTime(2020, 9, 18, 8, 0, 11, 672, DateTimeKind.Local).AddTicks(1222), 2 },
                    { 48, "Incidunt aliquid et ea perferendis eum voluptatem nihil et.", null, 9, new DateTime(2020, 9, 18, 6, 23, 45, 404, DateTimeKind.Local).AddTicks(2920), 4 },
                    { 18, "Tenetur esse vel.", null, 13, new DateTime(2020, 9, 18, 6, 5, 54, 312, DateTimeKind.Local).AddTicks(573), 3 },
                    { 22, "Optio similique in qui dicta quasi.", null, 13, new DateTime(2020, 9, 17, 17, 46, 26, 515, DateTimeKind.Local).AddTicks(7277), 4 },
                    { 26, "Dignissimos dolor totam doloribus.", null, 13, new DateTime(2020, 9, 18, 3, 55, 48, 734, DateTimeKind.Local).AddTicks(4236), 2 },
                    { 28, "Odio sed quae quod non error tempora id et itaque.", null, 13, new DateTime(2020, 9, 18, 9, 12, 47, 270, DateTimeKind.Local).AddTicks(2271), 1 },
                    { 44, "Ipsam in quo et perspiciatis praesentium quod ipsa velit temporibus.", null, 13, new DateTime(2020, 9, 18, 12, 27, 39, 937, DateTimeKind.Local).AddTicks(4344), 2 },
                    { 56, "Sed aut omnis ipsam.", null, 13, new DateTime(2020, 9, 18, 11, 6, 13, 259, DateTimeKind.Local).AddTicks(3375), 2 },
                    { 14, "Est vel earum dolore expedita qui aspernatur doloribus iure.", null, 15, new DateTime(2020, 9, 17, 17, 9, 33, 875, DateTimeKind.Local).AddTicks(4717), 1 },
                    { 4, "Repudiandae rerum autem omnis error necessitatibus.", null, 17, new DateTime(2020, 9, 17, 21, 32, 19, 610, DateTimeKind.Local).AddTicks(2792), 1 },
                    { 17, "Recusandae eos non eaque.", null, 17, new DateTime(2020, 9, 18, 3, 29, 50, 805, DateTimeKind.Local).AddTicks(6867), 2 },
                    { 30, "Omnis omnis aspernatur laboriosam architecto quasi illum.", null, 17, new DateTime(2020, 9, 18, 12, 32, 8, 887, DateTimeKind.Local).AddTicks(5992), 3 },
                    { 57, "Inventore ea ut necessitatibus vel eos ut autem temporibus debitis.", null, 17, new DateTime(2020, 9, 17, 15, 7, 41, 987, DateTimeKind.Local).AddTicks(1594), 1 },
                    { 50, "Aut deleniti sed voluptate quis itaque.", null, 2, new DateTime(2020, 9, 18, 3, 7, 19, 547, DateTimeKind.Local).AddTicks(407), 1 },
                    { 51, "Sit enim qui sit amet est voluptates impedit sit.", null, 2, new DateTime(2020, 9, 17, 13, 58, 24, 688, DateTimeKind.Local).AddTicks(5003), 3 },
                    { 45, "Et voluptas pariatur deserunt rerum explicabo voluptatum quasi tempora nostrum.", null, 3, new DateTime(2020, 9, 17, 23, 11, 50, 816, DateTimeKind.Local).AddTicks(5676), 3 },
                    { 6, "Iure ut dicta.", null, 6, new DateTime(2020, 9, 17, 22, 29, 37, 511, DateTimeKind.Local).AddTicks(8591), 1 },
                    { 8, "Ut adipisci et a voluptatem aliquid reiciendis.", null, 6, new DateTime(2020, 9, 17, 15, 55, 16, 798, DateTimeKind.Local).AddTicks(7117), 2 },
                    { 25, "Occaecati occaecati voluptas nesciunt officia in quisquam est.", null, 20, new DateTime(2020, 9, 18, 9, 2, 51, 21, DateTimeKind.Local).AddTicks(5093), 3 },
                    { 59, "Aut optio est et ullam consectetur temporibus quia quisquam.", null, 20, new DateTime(2020, 9, 18, 6, 58, 13, 621, DateTimeKind.Local).AddTicks(2033), 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40);

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
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 20);

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
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
