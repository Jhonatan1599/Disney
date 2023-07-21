// Ignore Spelling: Seedata

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DisneyAPI.Domain.Migrations
{
    public partial class changeSeedata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: new Guid("25f94e5b-7aa0-415a-9d3d-34edb85e3277"));

            migrationBuilder.DeleteData(
                table: "Character",
                keyColumn: "Id",
                keyValue: new Guid("ea9009f7-9c59-4944-81da-48ee5a773124"));

            migrationBuilder.DeleteData(
                table: "MoviesOrSerie",
                keyColumn: "Id",
                keyValue: new Guid("0ede5856-5245-41d4-9cbc-f74ad2bb6cdf"));

            migrationBuilder.DeleteData(
                table: "MoviesOrSerie",
                keyColumn: "Id",
                keyValue: new Guid("45e04d11-dd27-4b45-904b-ca527f7de124"));

            migrationBuilder.DeleteData(
                table: "MoviesOrSerie",
                keyColumn: "Id",
                keyValue: new Guid("ae471f1b-8d60-4489-8519-23b854237d0d"));

            migrationBuilder.DeleteData(
                table: "MoviesOrSerie",
                keyColumn: "Id",
                keyValue: new Guid("f976eacc-bc89-450b-944b-359c726f9c64"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("2dc506fe-16c8-4c8a-af98-425fca9424cc"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("935c52c6-b1e1-4dc9-968a-ba2564eaa7e2"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("a5af601b-5b6e-45b3-a60d-53111d60cd90"));

            migrationBuilder.DeleteData(
                table: "Genre",
                keyColumn: "Id",
                keyValue: new Guid("da36de85-3f72-4f14-9f35-8697e070c64e"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Character",
                columns: new[] { "Id", "Age", "ImageUrl", "Name", "Story", "Weight" },
                values: new object[,]
                {
                    { new Guid("25f94e5b-7aa0-415a-9d3d-34edb85e3277"), 92, "https://disney-api.app.csharpjourney.com/mickey.png", "Minnie Mouse", "Minnie Mouse is Mickey Mouse's girlfriend and one of Disney's iconic characters.", 21.4f },
                    { new Guid("ea9009f7-9c59-4944-81da-48ee5a773124"), 92, "https://disney-api.app.csharpjourney.com/minnie.png", "Mickey Mouse", "Mickey Mouse is the iconic and beloved character in Disney's cartoons.", 23.5f }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("2dc506fe-16c8-4c8a-af98-425fca9424cc"), "Fantasy" },
                    { new Guid("935c52c6-b1e1-4dc9-968a-ba2564eaa7e2"), "Family" },
                    { new Guid("a5af601b-5b6e-45b3-a60d-53111d60cd90"), "Animation" },
                    { new Guid("da36de85-3f72-4f14-9f35-8697e070c64e"), "Holiday" }
                });

            migrationBuilder.InsertData(
                table: "MoviesOrSerie",
                columns: new[] { "Id", "CreationDate", "GenreId", "ImageUrl", "Rating", "Title" },
                values: new object[,]
                {
                    { new Guid("0ede5856-5245-41d4-9cbc-f74ad2bb6cdf"), new DateTime(1999, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("da36de85-3f72-4f14-9f35-8697e070c64e"), "https://disney-api.app.csharpjourney.com/Mickeys-Once-Upon-a-Christmas.jpg", 7, "Mickey's Once Upon a Christmas" },
                    { new Guid("45e04d11-dd27-4b45-904b-ca527f7de124"), new DateTime(1940, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("2dc506fe-16c8-4c8a-af98-425fca9424cc"), "https://disney-api.app.csharpjourney.com/fantasia.jpg", 7, "Fantasia" },
                    { new Guid("ae471f1b-8d60-4489-8519-23b854237d0d"), new DateTime(1928, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("a5af601b-5b6e-45b3-a60d-53111d60cd90"), "https://disney-api.app.csharpjourney.com/Steamboat-Willie.jpg", 8, "Steamboat Willie" },
                    { new Guid("f976eacc-bc89-450b-944b-359c726f9c64"), new DateTime(1955, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("935c52c6-b1e1-4dc9-968a-ba2564eaa7e2"), "https://disney-api.app.csharpjourney.com/The-Mickey-Mouse-Club", 6, "The Mickey Mouse Club" }
                });
        }
    }
}
