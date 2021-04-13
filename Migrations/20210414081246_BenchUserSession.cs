using Microsoft.EntityFrameworkCore.Migrations;

namespace DiscordSharpBencher.Migrations
{
    public partial class BenchUserSession : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BenchUserSessionId",
                table: "BenchResults",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BenchUserSessionId",
                table: "BenchResults");
        }
    }
}
