using Microsoft.EntityFrameworkCore.Migrations;

namespace FrontToBack.Migrations
{
    public partial class secondproject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Desc", "ImageUrl", "Name", "Time" },
                values: new object[,]
                {
                    { 1, "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per", "blog-feature-img-1.jpg", "Flower Power", "29.12.2019 " },
                    { 2, "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per", "blog-feature-img-3.jpg", "Local Florist", "29.12.2019 " },
                    { 3, "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per", "blog-feature-img-4.jpg", "Local Florist", "29.12.2019 " }
                });

            migrationBuilder.InsertData(
                table: "CaruselBlogs",
                columns: new[] { "Id", "Desc", "ImageUrl", "Name", "Positation" },
                values: new object[,]
                {
                    { 1, "Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus  lingua.", "testimonial-img-1.png", "Anna Barnes", "Florist" },
                    { 2, "lorem", "testimonial-img-2.png", "Jasmine White", "Florist" }
                });

            migrationBuilder.InsertData(
                table: "Instagrams",
                columns: new[] { "Id", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "instagram1.jpg" },
                    { 2, "instagram2.jpg" },
                    { 3, "instagram3.jpg" },
                    { 4, "instagram4.jpg" },
                    { 5, "instagram5.jpg" },
                    { 6, "instagram6.jpg" },
                    { 7, "instagram7.jpg" },
                    { 8, "instagram8.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CaruselBlogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CaruselBlogs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Instagrams",
                keyColumn: "Id",
                keyValue: 8);
        }
    }
}
