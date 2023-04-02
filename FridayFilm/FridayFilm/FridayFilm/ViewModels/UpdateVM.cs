using FridayFilm.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FridayFilm.ViewModels
{
    public class UpdateVM
    {


        public string Name { get; set; }

        public int IMDB { get; set; }

        public string Desc { get; set; }
        public string Countr { get; set; }
        public string RealeaseYear { get; set; }
        public string RunnigTime { get; set; }
        public string AgeLimit { get; set; }

        public List<FilmGenre> FilmGenre { get; set; }
        public string Fragman { get; set; }

        public IFormFile Photos { get; set; }
        [Required]
        public List<int> GenreId { get; set; }
        public List<Genre> Genres { get; set; }

    }
}
