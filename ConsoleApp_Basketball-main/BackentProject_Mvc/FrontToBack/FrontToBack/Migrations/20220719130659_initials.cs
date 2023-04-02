using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBack.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Experts",
                columns: new[] { "Id", "ImageUrl", "Name", "Positation" },
                values: new object[,]
                {
                    { 2, "h3-team-img-1.png", "Crystal Brooks", "Florist" },
                    { 3, "h3-team-img-2.png", "Shirley Hirres", "Manager" },
                    { 4, "h3-team-img-3.png", "Beverly", "Florist" },
                    { 5, "h3-team-img-3.png", "Lorem", "Manager" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Experts",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
