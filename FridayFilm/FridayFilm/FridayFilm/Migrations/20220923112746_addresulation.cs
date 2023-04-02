using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayFilm.Migrations
{
    public partial class addresulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Limited",
                table: "Pricings",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Resulation",
                table: "Pricings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Limited",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "Resulation",
                table: "Pricings");
        }
    }
}
