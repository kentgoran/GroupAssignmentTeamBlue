using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class DataSeeding : Migration
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
                    { 2, 1, 1, 1 },
                    { 40, 4, 4, 2 },
                    { 39, 4, 4, 3 },
                    { 36, 4, 4, 3 },
                    { 27, 4, 4, 5 },
                    { 25, 4, 4, 3 },
                    { 19, 4, 4, 1 },
                    { 15, 4, 4, 1 },
                    { 12, 4, 4, 4 },
                    { 33, 2, 2, 3 },
                    { 7, 3, 3, 2 },
                    { 16, 3, 3, 1 },
                    { 17, 3, 3, 3 },
                    { 21, 3, 3, 5 },
                    { 28, 3, 3, 1 },
                    { 32, 3, 3, 3 },
                    { 35, 3, 3, 4 },
                    { 37, 3, 3, 3 },
                    { 3, 4, 4, 5 },
                    { 11, 3, 3, 2 },
                    { 24, 2, 2, 2 },
                    { 18, 2, 2, 1 },
                    { 6, 2, 2, 4 },
                    { 8, 1, 1, 5 },
                    { 9, 1, 1, 3 },
                    { 10, 1, 1, 4 },
                    { 13, 1, 1, 2 },
                    { 14, 1, 1, 2 },
                    { 20, 1, 1, 3 },
                    { 22, 1, 1, 4 },
                    { 23, 1, 1, 5 },
                    { 26, 1, 1, 3 },
                    { 29, 1, 1, 1 },
                    { 30, 1, 1, 5 },
                    { 31, 1, 1, 4 },
                    { 34, 1, 1, 4 },
                    { 38, 1, 1, 4 },
                    { 4, 2, 2, 3 },
                    { 5, 2, 2, 5 },
                    { 1, 4, 4, 4 }
                });

            migrationBuilder.InsertData(
                table: "RealEstates",
                columns: new[] { "Id", "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[,]
                {
                    { 10, "371 Abbigail Flat, Lake Kaylahchester, New Zealand", "Isaiasmouth", 1899, "Kade Paucek, $52733 Murphy Field, Yadiramouth, Indonesia", new DateTime(1899, 5, 23, 21, 49, 14, 998, DateTimeKind.Unspecified).AddTicks(3718), "Iusto perferendis vero eius nihil.", false, true, "https://seth.org", 0m, 39, 1257418m, 4776, "aut", 0, 4 },
                    { 3, "013 Mueller Streets, Goyetteville, Bermuda", "Lake Benland", 1982, "Corrine Wolff, $59284 Gibson Bypass, Walshburgh, Mozambique", new DateTime(1982, 6, 17, 17, 37, 15, 369, DateTimeKind.Unspecified).AddTicks(4511), "Illum architecto labore animi qui dolorem qui dolore dignissimos sit.", true, false, "https://lysanne.org", 8028m, 15, 0m, 225, "dolores", 3, 4 },
                    { 1, "91073 Feest Spurs, West Wilfridville, Senegal", "Littelville", 1644, "Laurine Carroll, $1908 Antone Manors, South Araceli, Sri Lanka", new DateTime(1644, 12, 23, 14, 5, 42, 386, DateTimeKind.Unspecified).AddTicks(4720), "Voluptatem fuga laudantium non ratione.", false, true, "http://kaia.name", 0m, 50, 1096466m, 4412, "laboriosam", 0, 4 },
                    { 18, "4760 Nikko Passage, Strosinchester, Suriname", "North Goldenville", 1605, "Hubert Bailey, $61496 Cyrus Station, Rowemouth, Togo", new DateTime(1605, 5, 21, 13, 11, 30, 167, DateTimeKind.Unspecified).AddTicks(8604), "Fugiat assumenda ut repudiandae est tenetur.", false, true, "http://lonnie.info", 0m, 14, 809079m, 1842, "ipsam", 1, 3 },
                    { 14, "5323 Senger Station, New Winnifred, Ghana", "South Anjalichester", 1864, "Kyle Hintz, $2805 Rohan Drive, Croninchester, Anguilla", new DateTime(1864, 12, 5, 5, 29, 40, 144, DateTimeKind.Unspecified).AddTicks(6619), "Consectetur quisquam ut tempore voluptatem quia expedita qui dicta.", false, true, "http://kendra.info", 0m, 17, 185109m, 1788, "magni", 2, 2 },
                    { 15, "01992 Toni Wall, West Ismael, Colombia", "New Emelia", 1691, "Luigi Hills, $207 Grady Shoals, Berniermouth, Sri Lanka", new DateTime(1691, 1, 25, 4, 43, 57, 562, DateTimeKind.Unspecified).AddTicks(4736), "Labore minima natus.", true, false, "http://fidel.org", 5169m, 18, 0m, 3242, "odio", 3, 3 },
                    { 12, "31125 Schmitt Pines, Horaciochester, Greenland", "Jerrellland", 1728, "Frank Gutkowski, $21636 Delphia Island, Emmaleetown, Moldova", new DateTime(1728, 3, 31, 13, 15, 59, 191, DateTimeKind.Unspecified).AddTicks(3863), "Accusamus blanditiis voluptas et recusandae molestiae explicabo possimus fugiat.", false, true, "https://irving.com", 0m, 6, 1855715m, 1280, "illum", 0, 3 },
                    { 20, "409 Franecki Ports, East Lukas, Seychelles", "Laishafurt", 1682, "Brielle Moen, $460 Rolfson Avenue, New Reubentown, Somalia", new DateTime(1682, 12, 23, 23, 20, 0, 724, DateTimeKind.Unspecified).AddTicks(2177), "Voluptate distinctio dolorem sunt sed sit autem.", false, true, "http://dandre.com", 0m, 27, 725558m, 3792, "incidunt", 2, 2 },
                    { 17, "135 Kihn Junction, Declanport, Tokelau", "South Rossville", 1646, "Franco Lueilwitz, $66463 Violet Station, Stephanyland, Turks and Caicos Islands", new DateTime(1646, 6, 9, 20, 1, 14, 970, DateTimeKind.Unspecified).AddTicks(4711), "Ipsam quod corrupti.", false, true, "http://gregoria.org", 0m, 18, 2048930m, 3765, "officiis", 3, 2 },
                    { 13, "54163 Ernestina Club, Port Meaghan, Zambia", "Lake Kiel", 1757, "Chyna Bartoletti, $769 Tracey Summit, Rosemaryview, Iraq", new DateTime(1757, 2, 26, 1, 42, 36, 325, DateTimeKind.Unspecified).AddTicks(6531), "Ut et cupiditate esse ex sit.", true, false, "http://delmer.name", 4636m, 15, 0m, 2812, "eos", 2, 4 },
                    { 9, "6002 Ally Knolls, New Bridie, Gambia", "Cecilborough", 1942, "Ludie Lang, $775 Wanda Flats, Leonieville, Mayotte", new DateTime(1942, 9, 4, 19, 4, 32, 70, DateTimeKind.Unspecified).AddTicks(6812), "Non quis asperiores ab quia quis.", true, false, "https://rowan.biz", 7232m, 34, 0m, 141, "mollitia", 0, 2 },
                    { 6, "918 Lebsack Highway, Port Myronborough, Georgia", "Olsonburgh", 1937, "Lyla Terry, $5500 Nick Shores, Briaside, Spain", new DateTime(1937, 1, 18, 22, 18, 22, 769, DateTimeKind.Unspecified).AddTicks(174), "Temporibus minima id atque voluptatem repellat quos consequatur facilis tenetur.", false, true, "https://eileen.org", 0m, 25, 2463133m, 2944, "nostrum", 3, 2 },
                    { 5, "9480 Stracke Parkway, South Royalstad, San Marino", "East Yessenia", 1600, "Arnaldo Powlowski, $2774 Moen Hills, Freemanville, American Samoa", new DateTime(1600, 3, 26, 11, 22, 23, 753, DateTimeKind.Unspecified).AddTicks(9992), "Possimus beatae cumque molestias cupiditate.", false, true, "https://delilah.info", 0m, 49, 1395514m, 1212, "optio", 0, 2 },
                    { 4, "95585 Johnpaul Forge, West Vern, Madagascar", "Port Koreyburgh", 1638, "Kylee Hyatt, $40968 Bernhard Bypass, Veumshire, Slovenia", new DateTime(1638, 4, 28, 17, 28, 16, 899, DateTimeKind.Unspecified).AddTicks(664), "Asperiores expedita quia cum cupiditate error quia.", true, false, "http://mathew.biz", 11503m, 6, 0m, 4065, "neque", 2, 2 },
                    { 2, "610 Zachariah River, North Josefort, Turkmenistan", "Port Arnoport", 1748, "Minnie Powlowski, $09659 Arthur Falls, Port Aglaeside, Haiti", new DateTime(1748, 6, 23, 12, 29, 43, 38, DateTimeKind.Unspecified).AddTicks(1469), "Molestias adipisci voluptatem ducimus atque.", false, true, "https://eugenia.com", 0m, 43, 2096745m, 415, "aut", 0, 2 },
                    { 11, "6990 Earlene Coves, South Sandrafurt, Equatorial Guinea", "Marvinberg", 1999, "Norwood Balistreri, $29490 Hellen Ridges, South Tomasatown, Cape Verde", new DateTime(1999, 8, 11, 17, 6, 12, 320, DateTimeKind.Unspecified).AddTicks(6539), "Rerum nihil voluptatem.", false, true, "http://matteo.info", 0m, 15, 1375355m, 2602, "odio", 1, 1 },
                    { 8, "874 Kilback Row, Port Shaylee, Sweden", "New Estefania", 1630, "Oral Zieme, $65166 Gino Loop, Anahishire, Belgium", new DateTime(1630, 3, 24, 13, 21, 47, 466, DateTimeKind.Unspecified).AddTicks(8661), "Voluptatem minima ut ut ex quae nihil.", false, true, "http://christophe.name", 0m, 42, 666453m, 1818, "et", 1, 1 },
                    { 7, "4394 Watsica Summit, North Oscarhaven, Marshall Islands", "East Alberthamouth", 1779, "Lilyan Kshlerin, $34772 Lind Place, South Enaberg, Madagascar", new DateTime(1779, 5, 1, 5, 46, 17, 18, DateTimeKind.Unspecified).AddTicks(322), "Necessitatibus dolor maxime animi qui et tempora dolorum dolorem.", false, true, "http://colleen.com", 0m, 49, 2061780m, 3581, "blanditiis", 0, 1 },
                    { 16, "68998 Watsica Highway, McKenzieside, India", "Abbottside", 1986, "Isabell Parker, $5486 Eloisa Street, Abnerborough, Canada", new DateTime(1986, 7, 24, 11, 38, 17, 70, DateTimeKind.Unspecified).AddTicks(8565), "Delectus autem quos id occaecati repellendus quis ut nemo ullam.", true, false, "https://axel.net", 10702m, 41, 0m, 4081, "quis", 1, 3 },
                    { 19, "4222 Wendy Ramp, Haagburgh, Cayman Islands", "Kohlerburgh", 1609, "Vicenta Gislason, $788 Faustino Cove, Loganbury, Macedonia", new DateTime(1609, 11, 24, 3, 8, 52, 455, DateTimeKind.Unspecified).AddTicks(8981), "Porro cupiditate nihil enim debitis blanditiis culpa ut adipisci.", false, true, "https://allison.biz", 0m, 15, 2470543m, 4937, "molestias", 1, 4 }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "ParentCommentId", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[,]
                {
                    { 15, "Consequatur nam recusandae tenetur odit nihil ut.", null, 7, new DateTime(2020, 9, 30, 5, 9, 9, 93, DateTimeKind.Local).AddTicks(1186), 4 },
                    { 1, "Aspernatur non placeat consequatur quo qui ad quia recusandae eos.", null, 17, new DateTime(2020, 9, 30, 1, 33, 10, 484, DateTimeKind.Local).AddTicks(2246), 3 },
                    { 14, "Omnis omnis aspernatur laboriosam architecto quasi illum.", null, 17, new DateTime(2020, 9, 30, 14, 9, 39, 261, DateTimeKind.Local).AddTicks(8212), 3 },
                    { 41, "Inventore ea ut necessitatibus vel eos ut autem temporibus debitis.", null, 17, new DateTime(2020, 9, 29, 16, 45, 12, 361, DateTimeKind.Local).AddTicks(4116), 1 },
                    { 8, "Atque natus asperiores.", null, 20, new DateTime(2020, 9, 30, 9, 29, 13, 452, DateTimeKind.Local).AddTicks(9928), 2 },
                    { 9, "Occaecati occaecati voluptas nesciunt officia in quisquam est.", null, 20, new DateTime(2020, 9, 30, 10, 40, 21, 395, DateTimeKind.Local).AddTicks(7307), 3 },
                    { 43, "Aut optio est et ullam consectetur temporibus quia quisquam.", null, 20, new DateTime(2020, 9, 30, 8, 35, 43, 995, DateTimeKind.Local).AddTicks(4578), 3 },
                    { 27, "Molestiae error quia enim reprehenderit aliquam.", null, 12, new DateTime(2020, 9, 29, 23, 16, 17, 672, DateTimeKind.Local).AddTicks(6548), 1 },
                    { 42, "Hic laudantium nam laborum officia ad nesciunt saepe illum provident.", null, 12, new DateTime(2020, 9, 30, 14, 17, 18, 639, DateTimeKind.Local).AddTicks(9206), 4 },
                    { 48, "Ut et ipsa qui tempore qui ab aperiam.", null, 12, new DateTime(2020, 9, 30, 11, 8, 52, 372, DateTimeKind.Local).AddTicks(3196), 4 },
                    { 49, "Aut quae reprehenderit maxime molestias laudantium fuga ut sit.", null, 12, new DateTime(2020, 9, 29, 17, 28, 49, 683, DateTimeKind.Local).AddTicks(2), 4 },
                    { 51, "Facilis inventore voluptas sed libero.", null, 12, new DateTime(2020, 9, 30, 7, 18, 52, 738, DateTimeKind.Local).AddTicks(9499), 3 },
                    { 55, "Commodi et numquam deleniti est earum repudiandae fugiat ea minus.", null, 12, new DateTime(2020, 9, 30, 14, 3, 30, 764, DateTimeKind.Local).AddTicks(4069), 1 },
                    { 59, "Qui dolorum molestiae.", null, 14, new DateTime(2020, 9, 30, 9, 10, 46, 479, DateTimeKind.Local).AddTicks(8036), 1 },
                    { 53, "Ducimus officiis asperiores perspiciatis ab saepe aut ut sunt.", null, 15, new DateTime(2020, 9, 29, 15, 55, 44, 222, DateTimeKind.Local).AddTicks(8263), 4 },
                    { 24, "Quibusdam voluptas eaque impedit praesentium.", null, 16, new DateTime(2020, 9, 30, 8, 39, 29, 321, DateTimeKind.Local).AddTicks(5586), 4 },
                    { 7, "Et nulla corrupti.", null, 18, new DateTime(2020, 9, 30, 3, 42, 4, 834, DateTimeKind.Local).AddTicks(3519), 3 },
                    { 29, "Et voluptas pariatur deserunt rerum explicabo voluptatum quasi tempora nostrum.", null, 3, new DateTime(2020, 9, 30, 0, 49, 21, 190, DateTimeKind.Local).AddTicks(8093), 3 },
                    { 3, "Ut commodi voluptate.", null, 10, new DateTime(2020, 9, 29, 17, 54, 50, 298, DateTimeKind.Local).AddTicks(2105), 1 },
                    { 20, "Et qui exercitationem omnis ab consequuntur nihil optio quia.", null, 10, new DateTime(2020, 9, 30, 6, 42, 1, 955, DateTimeKind.Local).AddTicks(883), 4 },
                    { 38, "Dolores assumenda eos perferendis iusto aut.", null, 10, new DateTime(2020, 9, 29, 23, 57, 14, 677, DateTimeKind.Local).AddTicks(8960), 2 },
                    { 6, "Optio similique in qui dicta quasi.", null, 13, new DateTime(2020, 9, 29, 19, 23, 56, 889, DateTimeKind.Local).AddTicks(9458), 4 },
                    { 10, "Dignissimos dolor totam doloribus.", null, 13, new DateTime(2020, 9, 30, 5, 33, 19, 108, DateTimeKind.Local).AddTicks(6456), 2 },
                    { 12, "Odio sed quae quod non error tempora id et itaque.", null, 13, new DateTime(2020, 9, 30, 10, 50, 17, 644, DateTimeKind.Local).AddTicks(4506), 1 },
                    { 28, "Ipsam in quo et perspiciatis praesentium quod ipsa velit temporibus.", null, 13, new DateTime(2020, 9, 30, 14, 5, 10, 311, DateTimeKind.Local).AddTicks(6687), 2 },
                    { 40, "Sed aut omnis ipsam.", null, 13, new DateTime(2020, 9, 30, 12, 43, 43, 633, DateTimeKind.Local).AddTicks(5888), 2 },
                    { 2, "Et veritatis tenetur esse vel.", null, 19, new DateTime(2020, 9, 30, 13, 39, 4, 227, DateTimeKind.Local).AddTicks(4539), 3 },
                    { 5, "Quae corrupti distinctio.", null, 16, new DateTime(2020, 9, 30, 7, 33, 41, 16, DateTimeKind.Local).AddTicks(1849), 4 },
                    { 25, "Vel tempora similique voluptas minus pariatur consectetur.", null, 14, new DateTime(2020, 9, 30, 0, 14, 22, 208, DateTimeKind.Local).AddTicks(2048), 4 },
                    { 50, "Quibusdam ea quas voluptatibus nobis omnis praesentium velit.", null, 9, new DateTime(2020, 9, 29, 18, 44, 55, 822, DateTimeKind.Local).AddTicks(5135), 2 },
                    { 32, "Incidunt aliquid et ea perferendis eum voluptatem nihil et.", null, 9, new DateTime(2020, 9, 30, 8, 1, 15, 778, DateTimeKind.Local).AddTicks(5367), 4 },
                    { 37, "Omnis voluptatum nihil officiis rerum repellat facilis dignissimos quia.", null, 7, new DateTime(2020, 9, 30, 1, 15, 53, 350, DateTimeKind.Local).AddTicks(1868), 2 },
                    { 44, "Corrupti dolores assumenda dolores.", null, 7, new DateTime(2020, 9, 29, 15, 38, 11, 388, DateTimeKind.Local).AddTicks(2643), 3 },
                    { 46, "Qui nihil repudiandae magni.", null, 7, new DateTime(2020, 9, 29, 19, 39, 59, 918, DateTimeKind.Local).AddTicks(9568), 3 },
                    { 52, "Necessitatibus ipsa officiis assumenda quia magni occaecati quis.", null, 7, new DateTime(2020, 9, 30, 8, 34, 37, 705, DateTimeKind.Local).AddTicks(2911), 2 },
                    { 11, "Voluptatem ducimus qui accusantium fugiat adipisci.", null, 8, new DateTime(2020, 9, 30, 9, 58, 41, 766, DateTimeKind.Local).AddTicks(4071), 2 },
                    { 39, "A quia suscipit voluptate consequatur veniam veniam.", null, 8, new DateTime(2020, 9, 30, 12, 41, 25, 927, DateTimeKind.Local).AddTicks(7935), 4 },
                    { 45, "Exercitationem et numquam.", null, 8, new DateTime(2020, 9, 30, 5, 42, 0, 223, DateTimeKind.Local).AddTicks(7160), 3 },
                    { 4, "Voluptas voluptates omnis inventore nostrum facilis eveniet et.", null, 11, new DateTime(2020, 9, 29, 19, 41, 29, 467, DateTimeKind.Local).AddTicks(8132), 1 },
                    { 17, "Eos libero nisi nam possimus hic in eos dolores.", null, 11, new DateTime(2020, 9, 29, 20, 1, 28, 210, DateTimeKind.Local).AddTicks(3169), 2 },
                    { 56, "Doloribus et ducimus ratione est sunt facilis ullam ipsa.", null, 11, new DateTime(2020, 9, 30, 9, 53, 20, 943, DateTimeKind.Local).AddTicks(7472), 1 },
                    { 34, "Aut deleniti sed voluptate quis itaque.", null, 2, new DateTime(2020, 9, 30, 4, 44, 49, 921, DateTimeKind.Local).AddTicks(2838), 1 },
                    { 35, "Sit enim qui sit amet est voluptates impedit sit.", null, 2, new DateTime(2020, 9, 29, 15, 35, 55, 62, DateTimeKind.Local).AddTicks(7476), 3 },
                    { 19, "Accusamus fugit consequatur itaque.", null, 4, new DateTime(2020, 9, 30, 1, 17, 20, 42, DateTimeKind.Local).AddTicks(6819), 4 },
                    { 30, "Quo ipsam quisquam quo dolores nostrum sunt.", null, 4, new DateTime(2020, 9, 30, 6, 49, 8, 77, DateTimeKind.Local).AddTicks(760), 2 },
                    { 33, "Quae sed quia rerum.", null, 4, new DateTime(2020, 9, 30, 4, 26, 10, 158, DateTimeKind.Local).AddTicks(9770), 2 },
                    { 23, "Enim assumenda sed vero nihil aut exercitationem.", null, 5, new DateTime(2020, 9, 30, 4, 17, 30, 932, DateTimeKind.Local).AddTicks(9358), 4 },
                    { 36, "Repellendus repellat alias expedita et.", null, 5, new DateTime(2020, 9, 29, 17, 43, 50, 0, DateTimeKind.Local).AddTicks(448), 4 },
                    { 54, "Et voluptate vero alias ut et.", null, 5, new DateTime(2020, 9, 29, 20, 43, 6, 799, DateTimeKind.Local).AddTicks(1626), 4 },
                    { 13, "Quas inventore pariatur.", null, 6, new DateTime(2020, 9, 29, 18, 44, 22, 855, DateTimeKind.Local).AddTicks(1779), 1 },
                    { 21, "Fugiat ea aliquid magnam at.", null, 6, new DateTime(2020, 9, 30, 9, 54, 55, 104, DateTimeKind.Local).AddTicks(6771), 1 },
                    { 47, "Ut sint quo.", null, 6, new DateTime(2020, 9, 30, 4, 3, 58, 630, DateTimeKind.Local).AddTicks(4359), 3 },
                    { 57, "Veniam autem debitis magnam id quam ut et.", null, 6, new DateTime(2020, 9, 30, 6, 25, 17, 225, DateTimeKind.Local).AddTicks(5804), 3 },
                    { 60, "Qui repudiandae eos.", null, 6, new DateTime(2020, 9, 29, 16, 6, 15, 97, DateTimeKind.Local).AddTicks(7725), 2 },
                    { 18, "Quisquam praesentium sunt.", null, 9, new DateTime(2020, 9, 30, 4, 46, 25, 446, DateTimeKind.Local).AddTicks(117), 2 },
                    { 22, "Neque delectus qui velit recusandae voluptatem vero ea.", null, 9, new DateTime(2020, 9, 30, 4, 31, 13, 574, DateTimeKind.Local).AddTicks(1336), 1 },
                    { 26, "Voluptas nesciunt placeat.", null, 9, new DateTime(2020, 9, 29, 18, 25, 11, 720, DateTimeKind.Local).AddTicks(5080), 4 },
                    { 31, "Cumque consequatur sint odio.", null, 9, new DateTime(2020, 9, 30, 9, 37, 42, 46, DateTimeKind.Local).AddTicks(3662), 2 },
                    { 16, "Ducimus qui quos quia laboriosam.", null, 19, new DateTime(2020, 9, 29, 20, 18, 51, 876, DateTimeKind.Local).AddTicks(667), 3 },
                    { 58, "Mollitia distinctio esse eum aspernatur hic.", null, 19, new DateTime(2020, 9, 29, 18, 29, 5, 201, DateTimeKind.Local).AddTicks(736), 2 }
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
