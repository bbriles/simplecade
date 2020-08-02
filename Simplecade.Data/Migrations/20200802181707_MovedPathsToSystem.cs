using Microsoft.EntityFrameworkCore.Migrations;

namespace Simplecade.Data.Migrations
{
    public partial class MovedPathsToSystem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        { 
            migrationBuilder.AddColumn<string>(
                name: "BackgroundPath",
                table: "Systems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoxArtPath",
                table: "Systems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SnapPath",
                table: "Systems",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoPath",
                table: "Systems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BackgroundPath",
                table: "Systems");

            migrationBuilder.DropColumn(
                name: "BoxArtPath",
                table: "Systems");

            migrationBuilder.DropColumn(
                name: "SnapPath",
                table: "Systems");

            migrationBuilder.DropColumn(
                name: "VideoPath",
                table: "Systems");

            migrationBuilder.AddColumn<string>(
                name: "BackgroundPath",
                table: "Configuration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BoxArtPath",
                table: "Configuration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SnapPath",
                table: "Configuration",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoPath",
                table: "Configuration",
                type: "TEXT",
                nullable: true);
        }
    }
}
