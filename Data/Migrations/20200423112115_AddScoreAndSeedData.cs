using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Highscore.Data.Migrations
{
    public partial class AddScoreAndSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Score",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Points = table.Column<long>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Player = table.Column<string>(nullable: true),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Score", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "Id", "Date", "GameId", "Player", "Points" },
                values: new object[] { 1, new DateTime(2019, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "John", 289983L });

            migrationBuilder.InsertData(
                table: "Score",
                columns: new[] { "Id", "Date", "GameId", "Player", "Points" },
                values: new object[] { 2, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Jane", 354632L });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Score");
        }
    }
}
