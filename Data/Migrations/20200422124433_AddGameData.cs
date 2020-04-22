using Microsoft.EntityFrameworkCore.Migrations;

namespace Highscore.Data.Migrations
{
    public partial class AddGameData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[] { 1, "Lorem ipsum dolor", "http://via.placeholder.com/640x480.png?text=Tetris", "Tetris" });

            migrationBuilder.InsertData(
                table: "Game",
                columns: new[] { "Id", "Description", "ImageUrl", "Title" },
                values: new object[] { 2, "Lorem ipsum dolor", "http://via.placeholder.com/640x480.png?text=Donkey+Kong", "Donkey Kong" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Game",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
