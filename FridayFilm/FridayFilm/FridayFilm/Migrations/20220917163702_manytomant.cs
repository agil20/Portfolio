using Microsoft.EntityFrameworkCore.Migrations;

namespace FridayFilm.Migrations
{
    public partial class manytomant : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_FilmGenres_FilmGenreId",
                table: "Films");

            migrationBuilder.DropForeignKey(
                name: "FK_Genres_FilmGenres_FilmGenreId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Genres_FilmGenreId",
                table: "Genres");

            migrationBuilder.DropIndex(
                name: "IX_Films_FilmGenreId",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "FilmGenreId",
                table: "Genres");

            migrationBuilder.DropColumn(
                name: "FilmGenreId",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "FilmGenres",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "FilmGenres",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FilmGenres_FilmId",
                table: "FilmGenres",
                column: "FilmId");

            migrationBuilder.CreateIndex(
                name: "IX_FilmGenres_GenreId",
                table: "FilmGenres",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenres_Films_FilmId",
                table: "FilmGenres",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FilmGenres_Genres_GenreId",
                table: "FilmGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenres_Films_FilmId",
                table: "FilmGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_FilmGenres_Genres_GenreId",
                table: "FilmGenres");

            migrationBuilder.DropIndex(
                name: "IX_FilmGenres_FilmId",
                table: "FilmGenres");

            migrationBuilder.DropIndex(
                name: "IX_FilmGenres_GenreId",
                table: "FilmGenres");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "FilmGenres");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "FilmGenres");

            migrationBuilder.AddColumn<int>(
                name: "FilmGenreId",
                table: "Genres",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FilmGenreId",
                table: "Films",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Genres_FilmGenreId",
                table: "Genres",
                column: "FilmGenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Films_FilmGenreId",
                table: "Films",
                column: "FilmGenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_FilmGenres_FilmGenreId",
                table: "Films",
                column: "FilmGenreId",
                principalTable: "FilmGenres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Genres_FilmGenres_FilmGenreId",
                table: "Genres",
                column: "FilmGenreId",
                principalTable: "FilmGenres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
