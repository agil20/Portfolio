using FridayFilm.Models;
using System.Collections.Generic;

namespace FridayFilm.ViewModels
{
    public class HomeVM
    {
        public int Id { get; set; }
        public List<Film> Films { get; set; }
        public List<Film> FilmsLoad { get; set; }
        
        public List<Genre> Genres { get; set; }
        public List<Film> FilmSearch { get; set; }
        public List<FilmGenre> FilmGenres { get; set; }


    }
}
