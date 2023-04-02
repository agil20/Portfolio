using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayFilm.Migrations
{
    public partial class filmUrladd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FilmUrl",
                table: "Films",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmUrl",
                table: "Films");
        }
    }
}
