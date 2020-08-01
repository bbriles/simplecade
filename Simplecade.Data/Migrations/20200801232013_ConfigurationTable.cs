using Microsoft.EntityFrameworkCore.Migrations;

namespace Simplecade.Data.Migrations
{
    public partial class ConfigurationTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configuration",
                columns: table => new
                {
                    ConfigurationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BoxArtPath = table.Column<string>(nullable: true),
                    VideoPath = table.Column<string>(nullable: true),
                    SnapPath = table.Column<string>(nullable: true),
                    BackgroundPath = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configuration", x => x.ConfigurationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configuration");
        }
    }
}
