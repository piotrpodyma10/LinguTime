using Microsoft.EntityFrameworkCore.Migrations;

namespace LinguTime.Domain.Migrations
{
    public partial class extendlanguagetable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Language",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Language");
        }
    }
}
