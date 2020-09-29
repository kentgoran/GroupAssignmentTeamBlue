using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupAssignmentTeamBlue.DAL.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_RealEstates_RealEstateId",
                table: "Pictures");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "RealEstates",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ListingUrl",
                table: "RealEstates",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Rooms",
                table: "RealEstates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SquareMeters",
                table: "RealEstates",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "RealEstateId",
                table: "Pictures",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Aspernatur non placeat consequatur quo qui ad quia recusandae eos.", 17, new DateTime(2020, 9, 29, 5, 40, 51, 296, DateTimeKind.Local).AddTicks(4326), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Et veritatis tenetur esse vel.", 19, new DateTime(2020, 9, 29, 17, 46, 45, 39, DateTimeKind.Local).AddTicks(8690), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Ut commodi voluptate.", 10, new DateTime(2020, 9, 28, 22, 2, 31, 110, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Voluptas voluptates omnis inventore nostrum facilis eveniet et.", 11, new DateTime(2020, 9, 28, 23, 49, 10, 280, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quae corrupti distinctio.", 16, new DateTime(2020, 9, 29, 11, 41, 21, 828, DateTimeKind.Local).AddTicks(6096), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Optio similique in qui dicta quasi.", 13, new DateTime(2020, 9, 28, 23, 31, 37, 702, DateTimeKind.Local).AddTicks(3820), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Et nulla corrupti.", 18, new DateTime(2020, 9, 29, 7, 49, 45, 646, DateTimeKind.Local).AddTicks(7862), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Atque natus asperiores.", 20, new DateTime(2020, 9, 29, 13, 36, 54, 265, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Occaecati occaecati voluptas nesciunt officia in quisquam est.", 20, new DateTime(2020, 9, 29, 14, 48, 2, 208, DateTimeKind.Local).AddTicks(1670), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Dignissimos dolor totam doloribus.", 13, new DateTime(2020, 9, 29, 9, 40, 59, 921, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Voluptatem ducimus qui accusantium fugiat adipisci.", 8, new DateTime(2020, 9, 29, 14, 6, 22, 578, DateTimeKind.Local).AddTicks(8467) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Odio sed quae quod non error tempora id et itaque.", 13, new DateTime(2020, 9, 29, 14, 57, 58, 456, DateTimeKind.Local).AddTicks(8919), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quas inventore pariatur.", 6, new DateTime(2020, 9, 28, 22, 52, 3, 667, DateTimeKind.Local).AddTicks(6271), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Omnis omnis aspernatur laboriosam architecto quasi illum.", 17, new DateTime(2020, 9, 29, 18, 17, 20, 74, DateTimeKind.Local).AddTicks(2721), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Consequatur nam recusandae tenetur odit nihil ut.", 7, new DateTime(2020, 9, 29, 9, 16, 49, 905, DateTimeKind.Local).AddTicks(5674) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Ducimus qui quos quia laboriosam.", 19, new DateTime(2020, 9, 29, 0, 26, 32, 688, DateTimeKind.Local).AddTicks(5171), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Eos libero nisi nam possimus hic in eos dolores.", 11, new DateTime(2020, 9, 29, 0, 9, 9, 22, DateTimeKind.Local).AddTicks(7684) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quisquam praesentium sunt.", 9, new DateTime(2020, 9, 29, 8, 54, 6, 258, DateTimeKind.Local).AddTicks(4653), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Accusamus fugit consequatur itaque.", 4, new DateTime(2020, 9, 29, 5, 25, 0, 855, DateTimeKind.Local).AddTicks(1366), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Et qui exercitationem omnis ab consequuntur nihil optio quia.", 10, new DateTime(2020, 9, 29, 10, 49, 42, 767, DateTimeKind.Local).AddTicks(5494), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Fugiat ea aliquid magnam at.", 6, new DateTime(2020, 9, 29, 14, 2, 35, 917, DateTimeKind.Local).AddTicks(1404), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Neque delectus qui velit recusandae voluptatem vero ea.", 9, new DateTime(2020, 9, 29, 8, 38, 54, 386, DateTimeKind.Local).AddTicks(5917), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Enim assumenda sed vero nihil aut exercitationem.", 5, new DateTime(2020, 9, 29, 8, 25, 11, 745, DateTimeKind.Local).AddTicks(3952), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quibusdam voluptas eaque impedit praesentium.", 16, new DateTime(2020, 9, 29, 12, 47, 10, 134, DateTimeKind.Local).AddTicks(200), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Vel tempora similique voluptas minus pariatur consectetur.", 14, new DateTime(2020, 9, 29, 4, 22, 3, 20, DateTimeKind.Local).AddTicks(6676), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Voluptas nesciunt placeat.", 9, new DateTime(2020, 9, 28, 22, 32, 52, 532, DateTimeKind.Local).AddTicks(9722), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Molestiae error quia enim reprehenderit aliquam.", 12, new DateTime(2020, 9, 29, 3, 23, 58, 485, DateTimeKind.Local).AddTicks(1252), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "TimeOfCreation", "UserId" },
                values: new object[] { "Ipsam in quo et perspiciatis praesentium quod ipsa velit temporibus.", new DateTime(2020, 9, 29, 18, 12, 51, 124, DateTimeKind.Local).AddTicks(1413), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Et voluptas pariatur deserunt rerum explicabo voluptatum quasi tempora nostrum.", 3, new DateTime(2020, 9, 29, 4, 57, 2, 3, DateTimeKind.Local).AddTicks(2770), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quo ipsam quisquam quo dolores nostrum sunt.", 4, new DateTime(2020, 9, 29, 10, 56, 48, 889, DateTimeKind.Local).AddTicks(5453), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Cumque consequatur sint odio.", 9, new DateTime(2020, 9, 29, 13, 45, 22, 858, DateTimeKind.Local).AddTicks(8368), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Incidunt aliquid et ea perferendis eum voluptatem nihil et.", 9, new DateTime(2020, 9, 29, 12, 8, 56, 591, DateTimeKind.Local).AddTicks(83), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Quae sed quia rerum.", 4, new DateTime(2020, 9, 29, 8, 33, 50, 971, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Aut deleniti sed voluptate quis itaque.", 2, new DateTime(2020, 9, 29, 8, 52, 30, 733, DateTimeKind.Local).AddTicks(7642), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Sit enim qui sit amet est voluptates impedit sit.", 2, new DateTime(2020, 9, 28, 19, 43, 35, 875, DateTimeKind.Local).AddTicks(2261), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Repellendus repellat alias expedita et.", 5, new DateTime(2020, 9, 28, 21, 51, 30, 812, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Omnis voluptatum nihil officiis rerum repellat facilis dignissimos quia.", 7, new DateTime(2020, 9, 29, 5, 23, 34, 162, DateTimeKind.Local).AddTicks(6685), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Dolores assumenda eos perferendis iusto aut.", 10, new DateTime(2020, 9, 29, 4, 4, 55, 490, DateTimeKind.Local).AddTicks(3796), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "A quia suscipit voluptate consequatur veniam veniam.", 8, new DateTime(2020, 9, 29, 16, 49, 6, 740, DateTimeKind.Local).AddTicks(2788) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Sed aut omnis ipsam.", 13, new DateTime(2020, 9, 29, 16, 51, 24, 446, DateTimeKind.Local).AddTicks(811), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Inventore ea ut necessitatibus vel eos ut autem temporibus debitis.", 17, new DateTime(2020, 9, 28, 20, 52, 53, 173, DateTimeKind.Local).AddTicks(9020), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Hic laudantium nam laborum officia ad nesciunt saepe illum provident.", 12, new DateTime(2020, 9, 29, 18, 24, 59, 452, DateTimeKind.Local).AddTicks(4128) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Aut optio est et ullam consectetur temporibus quia quisquam.", 20, new DateTime(2020, 9, 29, 12, 43, 24, 807, DateTimeKind.Local).AddTicks(9520), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Corrupti dolores assumenda dolores.", 7, new DateTime(2020, 9, 28, 19, 45, 52, 200, DateTimeKind.Local).AddTicks(7604), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Exercitationem et numquam.", 8, new DateTime(2020, 9, 29, 9, 49, 41, 36, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Qui nihil repudiandae magni.", 7, new DateTime(2020, 9, 28, 23, 47, 40, 731, DateTimeKind.Local).AddTicks(4661), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Ut sint quo.", 6, new DateTime(2020, 9, 29, 8, 11, 39, 442, DateTimeKind.Local).AddTicks(9473), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Ut et ipsa qui tempore qui ab aperiam.", 12, new DateTime(2020, 9, 29, 15, 16, 33, 184, DateTimeKind.Local).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Aut quae reprehenderit maxime molestias laudantium fuga ut sit.", 12, new DateTime(2020, 9, 28, 21, 36, 30, 495, DateTimeKind.Local).AddTicks(5109), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quibusdam ea quas voluptatibus nobis omnis praesentium velit.", 9, new DateTime(2020, 9, 28, 22, 52, 36, 635, DateTimeKind.Local).AddTicks(257), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Facilis inventore voluptas sed libero.", 12, new DateTime(2020, 9, 29, 11, 26, 33, 551, DateTimeKind.Local).AddTicks(4638) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Necessitatibus ipsa officiis assumenda quia magni occaecati quis.", 7, new DateTime(2020, 9, 29, 12, 42, 18, 517, DateTimeKind.Local).AddTicks(8064), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Ducimus officiis asperiores perspiciatis ab saepe aut ut sunt.", 15, new DateTime(2020, 9, 28, 20, 3, 25, 35, DateTimeKind.Local).AddTicks(3484), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Et voluptate vero alias ut et.", 5, new DateTime(2020, 9, 29, 0, 50, 47, 611, DateTimeKind.Local).AddTicks(6836), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Commodi et numquam deleniti est earum repudiandae fugiat ea minus.", 12, new DateTime(2020, 9, 29, 18, 11, 11, 576, DateTimeKind.Local).AddTicks(9291), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Doloribus et ducimus ratione est sunt facilis ullam ipsa.", 11, new DateTime(2020, 9, 29, 14, 1, 1, 756, DateTimeKind.Local).AddTicks(2713), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Veniam autem debitis magnam id quam ut et.", 6, new DateTime(2020, 9, 29, 10, 32, 58, 38, DateTimeKind.Local).AddTicks(1059), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Mollitia distinctio esse eum aspernatur hic.", 19, new DateTime(2020, 9, 28, 22, 36, 46, 13, DateTimeKind.Local).AddTicks(6004), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Qui dolorum molestiae.", 14, new DateTime(2020, 9, 29, 13, 18, 27, 292, DateTimeKind.Local).AddTicks(3396), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Qui repudiandae eos.", 6, new DateTime(2020, 9, 28, 20, 13, 55, 910, DateTimeKind.Local).AddTicks(3101), 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Score",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "Score",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                column: "Score",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "City", "ListingUrl", "Rooms", "SquareMeters" },
                values: new object[] { "Littelville", "http://kaia.name", 50, 4412 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type" },
                values: new object[] { "610 Zachariah River, North Josefort, Turkmenistan", "Port Arnoport", 1748, "Minnie Powlowski, $09659 Arthur Falls, Port Aglaeside, Haiti", new DateTime(1748, 6, 23, 12, 29, 43, 38, DateTimeKind.Unspecified).AddTicks(1469), "Molestias adipisci voluptatem ducimus atque.", false, true, "https://eugenia.com", 0m, 43, 2096745m, 415, "aut", 0 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "ListingUrl", "Rent", "Rooms", "SquareMeters", "Title", "UserId" },
                values: new object[] { "013 Mueller Streets, Goyetteville, Bermuda", "Lake Benland", 1982, "Corrine Wolff, $59284 Gibson Bypass, Walshburgh, Mozambique", new DateTime(1982, 6, 17, 17, 37, 15, 369, DateTimeKind.Unspecified).AddTicks(4511), "Illum architecto labore animi qui dolorem qui dolore dignissimos sit.", "https://lysanne.org", 8028m, 15, 225, "dolores", 4 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "95585 Johnpaul Forge, West Vern, Madagascar", "Port Koreyburgh", 1638, "Kylee Hyatt, $40968 Bernhard Bypass, Veumshire, Slovenia", new DateTime(1638, 4, 28, 17, 28, 16, 899, DateTimeKind.Unspecified).AddTicks(664), "Asperiores expedita quia cum cupiditate error quia.", true, false, "http://mathew.biz", 11503m, 6, 0m, 4065, "neque", 2, 2 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "ListingUrl", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "9480 Stracke Parkway, South Royalstad, San Marino", "East Yessenia", 1600, "Arnaldo Powlowski, $2774 Moen Hills, Freemanville, American Samoa", new DateTime(1600, 3, 26, 11, 22, 23, 753, DateTimeKind.Unspecified).AddTicks(9992), "Possimus beatae cumque molestias cupiditate.", "https://delilah.info", 49, 1395514m, 1212, "optio", 0, 2 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type" },
                values: new object[] { "918 Lebsack Highway, Port Myronborough, Georgia", "Olsonburgh", 1937, "Lyla Terry, $5500 Nick Shores, Briaside, Spain", new DateTime(1937, 1, 18, 22, 18, 22, 769, DateTimeKind.Unspecified).AddTicks(174), "Temporibus minima id atque voluptatem repellat quos consequatur facilis tenetur.", false, true, "https://eileen.org", 0m, 25, 2463133m, 2944, "nostrum", 3 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "ListingUrl", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "4394 Watsica Summit, North Oscarhaven, Marshall Islands", "East Alberthamouth", 1779, "Lilyan Kshlerin, $34772 Lind Place, South Enaberg, Madagascar", new DateTime(1779, 5, 1, 5, 46, 17, 18, DateTimeKind.Unspecified).AddTicks(322), "Necessitatibus dolor maxime animi qui et tempora dolorum dolorem.", "http://colleen.com", 49, 2061780m, 3581, "blanditiis", 0, 1 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "ListingUrl", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "874 Kilback Row, Port Shaylee, Sweden", "New Estefania", 1630, "Oral Zieme, $65166 Gino Loop, Anahishire, Belgium", new DateTime(1630, 3, 24, 13, 21, 47, 466, DateTimeKind.Unspecified).AddTicks(8661), "Voluptatem minima ut ut ex quae nihil.", "http://christophe.name", 42, 666453m, 1818, "et", 1, 1 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "6002 Ally Knolls, New Bridie, Gambia", "Cecilborough", 1942, "Ludie Lang, $775 Wanda Flats, Leonieville, Mayotte", new DateTime(1942, 9, 4, 19, 4, 32, 70, DateTimeKind.Unspecified).AddTicks(6812), "Non quis asperiores ab quia quis.", true, false, "https://rowan.biz", 7232m, 34, 0m, 141, "mollitia", 0, 2 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type" },
                values: new object[] { "371 Abbigail Flat, Lake Kaylahchester, New Zealand", "Isaiasmouth", 1899, "Kade Paucek, $52733 Murphy Field, Yadiramouth, Indonesia", new DateTime(1899, 5, 23, 21, 49, 14, 998, DateTimeKind.Unspecified).AddTicks(3718), "Iusto perferendis vero eius nihil.", false, true, "https://seth.org", 0m, 39, 1257418m, 4776, "aut", 0 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "6990 Earlene Coves, South Sandrafurt, Equatorial Guinea", "Marvinberg", 1999, "Norwood Balistreri, $29490 Hellen Ridges, South Tomasatown, Cape Verde", new DateTime(1999, 8, 11, 17, 6, 12, 320, DateTimeKind.Unspecified).AddTicks(6539), "Rerum nihil voluptatem.", false, true, "http://matteo.info", 0m, 15, 1375355m, 2602, "odio", 1, 1 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type" },
                values: new object[] { "31125 Schmitt Pines, Horaciochester, Greenland", "Jerrellland", 1728, "Frank Gutkowski, $21636 Delphia Island, Emmaleetown, Moldova", new DateTime(1728, 3, 31, 13, 15, 59, 191, DateTimeKind.Unspecified).AddTicks(3863), "Accusamus blanditiis voluptas et recusandae molestiae explicabo possimus fugiat.", false, true, "https://irving.com", 0m, 6, 1855715m, 1280, "illum", 0 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "54163 Ernestina Club, Port Meaghan, Zambia", "Lake Kiel", 1757, "Chyna Bartoletti, $769 Tracey Summit, Rosemaryview, Iraq", new DateTime(1757, 2, 26, 1, 42, 36, 325, DateTimeKind.Unspecified).AddTicks(6531), "Ut et cupiditate esse ex sit.", true, false, "http://delmer.name", 4636m, 15, 0m, 2812, "eos", 2, 4 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title" },
                values: new object[] { "5323 Senger Station, New Winnifred, Ghana", "South Anjalichester", 1864, "Kyle Hintz, $2805 Rohan Drive, Croninchester, Anguilla", new DateTime(1864, 12, 5, 5, 29, 40, 144, DateTimeKind.Unspecified).AddTicks(6619), "Consectetur quisquam ut tempore voluptatem quia expedita qui dicta.", false, true, "http://kendra.info", 0m, 17, 185109m, 1788, "magni" });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "01992 Toni Wall, West Ismael, Colombia", "New Emelia", 1691, "Luigi Hills, $207 Grady Shoals, Berniermouth, Sri Lanka", new DateTime(1691, 1, 25, 4, 43, 57, 562, DateTimeKind.Unspecified).AddTicks(4736), "Labore minima natus.", true, false, "http://fidel.org", 5169m, 18, 0m, 3242, "odio", 3, 3 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "ListingUrl", "Rent", "Rooms", "SquareMeters", "Title", "UserId" },
                values: new object[] { "68998 Watsica Highway, McKenzieside, India", "Abbottside", 1986, "Isabell Parker, $5486 Eloisa Street, Abnerborough, Canada", new DateTime(1986, 7, 24, 11, 38, 17, 70, DateTimeKind.Unspecified).AddTicks(8565), "Delectus autem quos id occaecati repellendus quis ut nemo ullam.", "https://axel.net", 10702m, 41, 4081, "quis", 3 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "135 Kihn Junction, Declanport, Tokelau", "South Rossville", 1646, "Franco Lueilwitz, $66463 Violet Station, Stephanyland, Turks and Caicos Islands", new DateTime(1646, 6, 9, 20, 1, 14, 970, DateTimeKind.Unspecified).AddTicks(4711), "Ipsam quod corrupti.", false, true, "http://gregoria.org", 0m, 18, 2048930m, 3765, "officiis", 3, 2 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "4760 Nikko Passage, Strosinchester, Suriname", "North Goldenville", 1605, "Hubert Bailey, $61496 Cyrus Station, Rowemouth, Togo", new DateTime(1605, 5, 21, 13, 11, 30, 167, DateTimeKind.Unspecified).AddTicks(8604), "Fugiat assumenda ut repudiandae est tenetur.", false, true, "http://lonnie.info", 0m, 14, 809079m, 1842, "ipsam", 1, 3 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "ListingUrl", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "4222 Wendy Ramp, Haagburgh, Cayman Islands", "Kohlerburgh", 1609, "Vicenta Gislason, $788 Faustino Cove, Loganbury, Macedonia", new DateTime(1609, 11, 24, 3, 8, 52, 455, DateTimeKind.Unspecified).AddTicks(8981), "Porro cupiditate nihil enim debitis blanditiis culpa ut adipisci.", "https://allison.biz", 15, 2470543m, 4937, "molestias", 1, 4 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "City", "YearBuilt", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "ListingUrl", "Rent", "Rooms", "SellPrice", "SquareMeters", "Title", "Type", "UserId" },
                values: new object[] { "409 Franecki Ports, East Lukas, Seychelles", "Laishafurt", 1682, "Brielle Moen, $460 Rolfson Avenue, New Reubentown, Somalia", new DateTime(1682, 12, 23, 23, 20, 0, 724, DateTimeKind.Unspecified).AddTicks(2177), "Voluptate distinctio dolorem sunt sed sit autem.", false, true, "http://dandre.com", 0m, 27, 725558m, 3792, "incidunt", 2, 2 });

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_RealEstates_RealEstateId",
                table: "Pictures",
                column: "RealEstateId",
                principalTable: "RealEstates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pictures_RealEstates_RealEstateId",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "City",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "ListingUrl",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "Rooms",
                table: "RealEstates");

            migrationBuilder.DropColumn(
                name: "SquareMeters",
                table: "RealEstates");

            migrationBuilder.AlterColumn<int>(
                name: "RealEstateId",
                table: "Pictures",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Tempore aut odio sed similique pariatur neque aut in tenetur.", 11, new DateTime(2020, 9, 20, 10, 15, 49, 468, DateTimeKind.Local).AddTicks(1807), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Fugiat assumenda ut repudiandae est tenetur.", 16, new DateTime(2020, 9, 20, 23, 4, 30, 651, DateTimeKind.Local).AddTicks(8835), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Alias non eius.", 11, new DateTime(2020, 9, 20, 21, 14, 23, 362, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Repudiandae rerum autem omnis error necessitatibus.", 17, new DateTime(2020, 9, 20, 16, 17, 16, 287, DateTimeKind.Local).AddTicks(9832) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Qui voluptatum omnis est voluptatem quo accusamus est nulla.", 11, new DateTime(2020, 9, 20, 23, 41, 52, 266, DateTimeKind.Local).AddTicks(2610), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Iure ut dicta.", 6, new DateTime(2020, 9, 20, 17, 14, 34, 189, DateTimeKind.Local).AddTicks(5713), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Aliquid consequatur enim molestias quo porro cupiditate nihil.", 8, new DateTime(2020, 9, 21, 2, 55, 4, 333, DateTimeKind.Local).AddTicks(9234), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Ut adipisci et a voluptatem aliquid reiciendis.", 6, new DateTime(2020, 9, 20, 10, 40, 13, 476, DateTimeKind.Local).AddTicks(4245) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Eos nulla tempore et ea cupiditate deleniti dolores voluptatem.", 8, new DateTime(2020, 9, 20, 23, 20, 50, 944, DateTimeKind.Local).AddTicks(5005), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Quia aliquam at corporis.", 20, new DateTime(2020, 9, 20, 15, 35, 27, 352, DateTimeKind.Local).AddTicks(5597) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Illum voluptatem eveniet illum laudantium ad qui ipsa eius maiores.", 7, new DateTime(2020, 9, 21, 3, 47, 4, 16, DateTimeKind.Local).AddTicks(2759) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Distinctio dolorem sunt sed sit autem.", 6, new DateTime(2020, 9, 21, 2, 9, 41, 656, DateTimeKind.Local).AddTicks(6577), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Temporibus nihil facere consequatur et cum inventore amet.", 8, new DateTime(2020, 9, 21, 4, 25, 42, 361, DateTimeKind.Local).AddTicks(3889), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Est vel earum dolore expedita qui aspernatur doloribus iure.", 15, new DateTime(2020, 9, 20, 11, 54, 30, 553, DateTimeKind.Local).AddTicks(1857), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Est numquam adipisci voluptatibus fuga officia soluta.", 4, new DateTime(2020, 9, 20, 16, 13, 56, 777, DateTimeKind.Local).AddTicks(4764) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Cupiditate vel perspiciatis perspiciatis non aspernatur non placeat consequatur.", 9, new DateTime(2020, 9, 21, 2, 19, 15, 586, DateTimeKind.Local).AddTicks(8191), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Recusandae eos non eaque.", 17, new DateTime(2020, 9, 20, 22, 14, 47, 483, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Tenetur esse vel.", 13, new DateTime(2020, 9, 21, 0, 50, 50, 989, DateTimeKind.Local).AddTicks(7670), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Ut commodi voluptate.", 10, new DateTime(2020, 9, 20, 11, 2, 16, 601, DateTimeKind.Local).AddTicks(7086), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Voluptas voluptates omnis inventore nostrum facilis eveniet et.", 11, new DateTime(2020, 9, 20, 12, 48, 55, 771, DateTimeKind.Local).AddTicks(3102), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quae corrupti distinctio.", 16, new DateTime(2020, 9, 21, 0, 41, 7, 319, DateTimeKind.Local).AddTicks(6812), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Optio similique in qui dicta quasi.", 13, new DateTime(2020, 9, 20, 12, 31, 23, 193, DateTimeKind.Local).AddTicks(4416), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Et nulla corrupti.", 18, new DateTime(2020, 9, 20, 20, 49, 31, 137, DateTimeKind.Local).AddTicks(8430), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Atque natus asperiores.", 20, new DateTime(2020, 9, 21, 2, 36, 39, 756, DateTimeKind.Local).AddTicks(4832), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Occaecati occaecati voluptas nesciunt officia in quisquam est.", 20, new DateTime(2020, 9, 21, 3, 47, 47, 699, DateTimeKind.Local).AddTicks(2206), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Dignissimos dolor totam doloribus.", 13, new DateTime(2020, 9, 20, 22, 40, 45, 412, DateTimeKind.Local).AddTicks(1353), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Voluptatem ducimus qui accusantium fugiat adipisci.", 8, new DateTime(2020, 9, 21, 3, 6, 8, 69, DateTimeKind.Local).AddTicks(8997), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Content", "TimeOfCreation", "UserId" },
                values: new object[] { "Odio sed quae quod non error tempora id et itaque.", new DateTime(2020, 9, 21, 3, 57, 43, 947, DateTimeKind.Local).AddTicks(9427), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quas inventore pariatur.", 6, new DateTime(2020, 9, 20, 11, 51, 49, 158, DateTimeKind.Local).AddTicks(6695), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Omnis omnis aspernatur laboriosam architecto quasi illum.", 17, new DateTime(2020, 9, 21, 7, 17, 5, 565, DateTimeKind.Local).AddTicks(3124), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Consequatur nam recusandae tenetur odit nihil ut.", 7, new DateTime(2020, 9, 20, 22, 16, 35, 396, DateTimeKind.Local).AddTicks(6055), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Ducimus qui quos quia laboriosam.", 19, new DateTime(2020, 9, 20, 13, 26, 18, 179, DateTimeKind.Local).AddTicks(5530), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Eos libero nisi nam possimus hic in eos dolores.", 11, new DateTime(2020, 9, 20, 13, 8, 54, 513, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quisquam praesentium sunt.", 9, new DateTime(2020, 9, 20, 21, 53, 51, 749, DateTimeKind.Local).AddTicks(5004), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Accusamus fugit consequatur itaque.", 4, new DateTime(2020, 9, 20, 18, 24, 46, 346, DateTimeKind.Local).AddTicks(1704), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Et qui exercitationem omnis ab consequuntur nihil optio quia.", 10, new DateTime(2020, 9, 20, 23, 49, 28, 258, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Fugiat ea aliquid magnam at.", 6, new DateTime(2020, 9, 21, 3, 2, 21, 408, DateTimeKind.Local).AddTicks(1646), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Neque delectus qui velit recusandae voluptatem vero ea.", 9, new DateTime(2020, 9, 20, 21, 38, 39, 877, DateTimeKind.Local).AddTicks(6140), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Enim assumenda sed vero nihil aut exercitationem.", 5, new DateTime(2020, 9, 20, 21, 24, 57, 236, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quibusdam voluptas eaque impedit praesentium.", 16, new DateTime(2020, 9, 21, 1, 46, 55, 625, DateTimeKind.Local).AddTicks(373), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Vel tempora similique voluptas minus pariatur consectetur.", 14, new DateTime(2020, 9, 20, 17, 21, 48, 511, DateTimeKind.Local).AddTicks(6887), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Voluptas nesciunt placeat.", 9, new DateTime(2020, 9, 20, 11, 32, 38, 23, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Molestiae error quia enim reprehenderit aliquam.", 12, new DateTime(2020, 9, 20, 16, 23, 43, 976, DateTimeKind.Local).AddTicks(1382), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Ipsam in quo et perspiciatis praesentium quod ipsa velit temporibus.", 13, new DateTime(2020, 9, 21, 7, 12, 36, 615, DateTimeKind.Local).AddTicks(1516), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Et voluptas pariatur deserunt rerum explicabo voluptatum quasi tempora nostrum.", 3, new DateTime(2020, 9, 20, 17, 56, 47, 494, DateTimeKind.Local).AddTicks(2846) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quo ipsam quisquam quo dolores nostrum sunt.", 4, new DateTime(2020, 9, 20, 23, 56, 34, 380, DateTimeKind.Local).AddTicks(5503), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Cumque consequatur sint odio.", 9, new DateTime(2020, 9, 21, 2, 45, 8, 349, DateTimeKind.Local).AddTicks(8434), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Incidunt aliquid et ea perferendis eum voluptatem nihil et.", 9, new DateTime(2020, 9, 21, 1, 8, 42, 82, DateTimeKind.Local).AddTicks(135) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Quae sed quia rerum.", 4, new DateTime(2020, 9, 20, 21, 33, 36, 462, DateTimeKind.Local).AddTicks(4533), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Aut deleniti sed voluptate quis itaque.", 2, new DateTime(2020, 9, 20, 21, 52, 16, 224, DateTimeKind.Local).AddTicks(7598), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation" },
                values: new object[] { "Sit enim qui sit amet est voluptates impedit sit.", 2, new DateTime(2020, 9, 20, 8, 43, 21, 366, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Repellendus repellat alias expedita et.", 5, new DateTime(2020, 9, 20, 10, 51, 16, 303, DateTimeKind.Local).AddTicks(5160), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Omnis voluptatum nihil officiis rerum repellat facilis dignissimos quia.", 7, new DateTime(2020, 9, 20, 18, 23, 19, 653, DateTimeKind.Local).AddTicks(6575), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Dolores assumenda eos perferendis iusto aut.", 10, new DateTime(2020, 9, 20, 17, 4, 40, 981, DateTimeKind.Local).AddTicks(3694), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "A quia suscipit voluptate consequatur veniam veniam.", 8, new DateTime(2020, 9, 21, 5, 48, 52, 231, DateTimeKind.Local).AddTicks(2666), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Sed aut omnis ipsam.", 13, new DateTime(2020, 9, 21, 5, 51, 9, 937, DateTimeKind.Local).AddTicks(615), 2 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Inventore ea ut necessitatibus vel eos ut autem temporibus debitis.", 17, new DateTime(2020, 9, 20, 9, 52, 38, 664, DateTimeKind.Local).AddTicks(8807), 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Hic laudantium nam laborum officia ad nesciunt saepe illum provident.", 12, new DateTime(2020, 9, 21, 7, 24, 44, 943, DateTimeKind.Local).AddTicks(3890), 4 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Aut optio est et ullam consectetur temporibus quia quisquam.", 20, new DateTime(2020, 9, 21, 1, 43, 10, 298, DateTimeKind.Local).AddTicks(9256), 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Content", "RealEstateId", "TimeOfCreation", "UserId" },
                values: new object[] { "Corrupti dolores assumenda dolores.", 7, new DateTime(2020, 9, 20, 8, 45, 37, 691, DateTimeKind.Local).AddTicks(7349), 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 2,
                column: "Score",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 3,
                column: "Score",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 4,
                column: "Score",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 2, 2, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 2, 2, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 15,
                column: "Score",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 2, 2, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 23,
                column: "Score",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 4 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 1, 1, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 28,
                column: "Score",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 3, 3, 1 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 5 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "RatedUserId", "RatingUserId", "Score" },
                values: new object[] { 4, 4, 2 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Ratings",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "RatedUserId", "RatingUserId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "YearBuilt" },
                values: new object[] { "930 Sonya Bridge, Feilshire, Philippines", "Jody Dietrich, $6304 Howell Roads, East Angusshire, Palestinian Territory", new DateTime(1649, 1, 23, 3, 0, 38, 110, DateTimeKind.Unspecified).AddTicks(377), "Velit eaque sed quidem aut doloribus aut.", true, false, 4866m, 0m, "quo", 2, 1649 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "Rent", "Title", "UserId", "YearBuilt" },
                values: new object[] { "62059 Hilpert Brooks, Lake Haylie, Turkmenistan", "Nico Hauck, $80258 Cole Turnpike, South Dellview, Andorra", new DateTime(1702, 11, 23, 20, 53, 52, 222, DateTimeKind.Unspecified).AddTicks(9110), "Sint consequuntur provident est aliquid deleniti aut voluptatibus vitae.", 9329m, "sint", 2, 1702 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "6552 Okuneva Haven, New Golden, Canada", "Verlie Bode, $117 Barton Springs, Scarletttown, French Guiana", new DateTime(1616, 5, 29, 9, 10, 21, 867, DateTimeKind.Unspecified).AddTicks(6542), "Nulla sit qui corporis maiores minima sed.", false, true, 0m, 301994m, "vero", 0, 1, 1616 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "628 Goodwin Cape, New Dorrismouth, Belarus", "Wilton Mayert, $955 Hagenes Heights, Port Audra, Germany", new DateTime(1742, 1, 30, 16, 57, 59, 687, DateTimeKind.Unspecified).AddTicks(1157), "Animi necessitatibus pariatur repudiandae a vel voluptatem amet atque excepturi.", 1620100m, "veritatis", 2, 1, 1742 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "YearBuilt" },
                values: new object[] { "57264 Jared Summit, East Elsieville, Yemen", "Elfrieda Rowe, $0758 Hills Ferry, Marquardtside, Italy", new DateTime(1701, 12, 22, 1, 58, 30, 272, DateTimeKind.Unspecified).AddTicks(5613), "Animi illum id.", true, false, 7236m, 0m, "optio", 2, 1701 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "918 Lebsack Highway, Port Myronborough, Georgia", "Lyla Terry, $5500 Nick Shores, Briaside, Spain", new DateTime(1937, 1, 18, 22, 18, 22, 769, DateTimeKind.Unspecified).AddTicks(174), "Temporibus minima id atque voluptatem repellat quos consequatur facilis tenetur.", 2463133m, "nostrum", 3, 2, 1937 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "2243 Myrtle Square, South Savannahmouth, Saint Barthelemy", "Oswaldo Rodriguez, $1164 Dante Plaza, Alfhaven, Maldives", new DateTime(1762, 12, 13, 0, 28, 4, 514, DateTimeKind.Unspecified).AddTicks(6217), "Corporis eveniet nostrum ut officia atque blanditiis possimus.", 1504483m, "vel", 3, 4, 1762 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "4179 Hermiston Canyon, North Houstonbury, Republic of Korea", "Mabel Padberg, $72207 Dominic Brooks, Morissettemouth, Eritrea", new DateTime(1884, 8, 15, 16, 41, 41, 892, DateTimeKind.Unspecified).AddTicks(3384), "Eos dolor necessitatibus omnis.", false, true, 0m, 646934m, "odio", 2, 1, 1884 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "YearBuilt" },
                values: new object[] { "1538 Hartmann Burgs, Jeffrymouth, Finland", "Reta Kilback, $888 Johnston Hill, Port Cleta, Bangladesh", new DateTime(1721, 4, 6, 23, 51, 46, 885, DateTimeKind.Unspecified).AddTicks(6356), "Doloribus vitae quaerat.", true, false, 6150m, 0m, "non", 3, 1721 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "65136 Evangeline Station, Friesentown, Palau", "Jocelyn Monahan, $0460 Moen Keys, East Jaimestad, Burkina Faso", new DateTime(1606, 11, 8, 22, 40, 36, 380, DateTimeKind.Unspecified).AddTicks(2113), "Modi reiciendis praesentium aut incidunt cumque placeat.", true, false, 7981m, 0m, "facilis", 0, 3, 1606 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "YearBuilt" },
                values: new object[] { "75762 Cormier Bridge, Graysonchester, Hong Kong", "Cristopher Marks, $954 Ena Ports, Shieldstown, Afghanistan", new DateTime(1939, 11, 16, 13, 27, 43, 678, DateTimeKind.Unspecified).AddTicks(3721), "Et provident nobis mollitia consequatur et.", true, false, 10467m, 0m, "eius", 2, 1939 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "0486 Wiegand Corners, West Meggie, Japan", "Charlie Jones, $00590 King Ways, Port Leonardburgh, Falkland Islands (Malvinas)", new DateTime(1842, 3, 22, 18, 22, 47, 197, DateTimeKind.Unspecified).AddTicks(7649), "Est odio sunt rerum nihil voluptatem fugit voluptas accusantium aliquam.", false, true, 0m, 2967411m, "earum", 3, 1, 1842 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "YearBuilt" },
                values: new object[] { "305 Loren Orchard, Emmaleemouth, Sierra Leone", "Travis Walsh, $300 Nolan Island, East Frances, Eritrea", new DateTime(1660, 3, 24, 18, 17, 44, 236, DateTimeKind.Unspecified).AddTicks(9860), "Deleniti occaecati ullam illum aut accusamus blanditiis voluptas.", true, false, 5590m, 0m, "nostrum", 1660 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "919 Alexandria Camp, Sawaynfurt, Uganda", "Marshall Kunze, $114 Bianka Fork, Port Judebury, Guatemala", new DateTime(1775, 1, 11, 4, 58, 47, 660, DateTimeKind.Unspecified).AddTicks(8044), "Et qui laboriosam numquam hic id nemo.", false, true, 0m, 1449966m, "deserunt", 2, 1, 1775 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "Rent", "Title", "UserId", "YearBuilt" },
                values: new object[] { "8172 Greenholt Crescent, Alannaville, Norfolk Island", "Brandi Pfannerstill, $60031 Purdy Well, Lake Kiel, Equatorial Guinea", new DateTime(1846, 5, 16, 13, 55, 26, 780, DateTimeKind.Unspecified).AddTicks(9997), "Voluptas dicta mollitia.", 6655m, "dolore", 2, 1846 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "7069 Hansen Rapid, South Anjalichester, Czech Republic", "Kellen Vandervort, $988 Maddison Locks, Ellisburgh, Ghana", new DateTime(1740, 6, 8, 21, 48, 17, 663, DateTimeKind.Unspecified).AddTicks(2573), "Optio placeat dolorem incidunt at.", true, false, 7356m, 0m, "veritatis", 2, 1, 1740 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "24341 Vilma Villages, Ferryton, Croatia", "Nicholas Padberg, $78078 Grady Corners, Annettaton, Ukraine", new DateTime(1732, 1, 13, 11, 1, 40, 240, DateTimeKind.Unspecified).AddTicks(7676), "Minima natus sunt facilis.", true, false, 9966m, 0m, "aperiam", 0, 2, 1732 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "07936 Carlee Ford, Ziemeshire, Svalbard & Jan Mayen Islands", "Wade Hackett, $5238 Marisa Lakes, Harveyhaven, Niue", new DateTime(1769, 6, 30, 18, 0, 26, 696, DateTimeKind.Unspecified).AddTicks(6466), "Est ea quis delectus delectus autem quos id occaecati repellendus.", 2799231m, "ex", 3, 2, 1769 });

            migrationBuilder.UpdateData(
                table: "RealEstates",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Address", "Contact", "DateOfAdvertCreation", "Description", "IsRentable", "IsSellable", "Rent", "SellPrice", "Title", "Type", "UserId", "YearBuilt" },
                values: new object[] { "9195 Harris Roads, Rauview, Holy See (Vatican City State)", "Savanna Brakus, $532 Gerhard Island, Port Rahul, Myanmar", new DateTime(1858, 3, 30, 10, 57, 49, 18, DateTimeKind.Unspecified).AddTicks(3645), "Sint natus delectus alias eveniet molestias aspernatur eligendi illum.", true, false, 8703m, 0m, "ut", 0, 4, 1858 });

            migrationBuilder.AddForeignKey(
                name: "FK_Pictures_RealEstates_RealEstateId",
                table: "Pictures",
                column: "RealEstateId",
                principalTable: "RealEstates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
