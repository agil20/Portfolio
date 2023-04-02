using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayFilm.Migrations
{
    public partial class addduration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Duration",
                table: "Pricings",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Pricings");
        }
    }
}
