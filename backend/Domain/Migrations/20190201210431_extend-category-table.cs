using Microsoft.EntityFrameworkCore.Migrations;

namespace LinguTime.Domain.Migrations
{
    public partial class extendcategorytable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Category");
        }
    }
}
