using Microsoft.EntityFrameworkCore.Migrations;

namespace Simplecade.Data.Migrations
{
    public partial class ListIconPath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ListIconPath",
                table: "Systems",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ListIconPath",
                table: "Systems");
        }
    }
}
