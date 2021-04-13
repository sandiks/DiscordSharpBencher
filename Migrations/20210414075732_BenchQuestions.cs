using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscordSharpBencher.Migrations
{
    public partial class BenchQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BenchAreas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AreaName = table.Column<string>(type: "TEXT", nullable: true),
                    CreatedAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenchAreas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BenchQuestions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BenchAreaId = table.Column<long>(type: "INTEGER", nullable: false),
                    QuestText = table.Column<string>(type: "TEXT", nullable: true),
                    MultiOptional = table.Column<bool>(type: "INTEGER", nullable: false),
                    QuestAnswers = table.Column<string>(type: "TEXT", nullable: true),
                    CorrectAnswer = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenchQuestions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BenchResults",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BenchQuestionId = table.Column<long>(type: "INTEGER", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", nullable: true),
                    Result = table.Column<string>(type: "TEXT", nullable: true),
                    ProceededAt = table.Column<DateTimeOffset>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenchResults", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BenchAreas");

            migrationBuilder.DropTable(
                name: "BenchQuestions");

            migrationBuilder.DropTable(
                name: "BenchResults");
        }
    }
}
