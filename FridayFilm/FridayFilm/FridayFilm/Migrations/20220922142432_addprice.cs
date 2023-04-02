using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayFilm.Migrations
{
    public partial class addprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Basic",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "Cinematic",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "Premium",
                table: "Pricings");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Pricings",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Pricings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Pricings");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Pricings");

            migrationBuilder.AddColumn<int>(
                name: "Basic",
                table: "Pricings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Cinematic",
                table: "Pricings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Premium",
                table: "Pricings",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
