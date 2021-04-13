using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscordSharpBencher.Migrations
{
    public partial class DeleteSampleTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EightBallAnswer");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EightBallAnswer",
                columns: table => new
                {
                    AnswerId = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnswerColor = table.Column<string>(type: "TEXT", nullable: true),
                    AnswerText = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EightBallAnswer", x => x.AnswerId);
                });
        }
    }
}
