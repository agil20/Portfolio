using System.Collections.Generic;

namespace FridayFilm.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<FilmGenre> FilmGenre { get; set; }
        public bool IsDelete { get; set; }

    }
}
