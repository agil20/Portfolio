using FridayFilm.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FridayFilm.ViewModels
{
    public class ProductCreateVM
    {
       
     
       

        [Required, MaxLength(100, ErrorMessage = "Can not be more than 15"), MinLength(5, ErrorMessage = "Can not be less than 5")]

        public string Name { get; set; }
       
        public int IMDB { get; set; }
        [Required, MinLength(30, ErrorMessage = "Description can not be less than 30"), MaxLength(500, ErrorMessage = "Description can not be more than 500")]

        public string Desc { get; set; }
        public string Countr { get; set; }
        public string RealeaseYear { get; set; }
        public string RunnigTime { get; set; }
        public string AgeLimit { get; set; }
        public string FilmUrl { get; set; }

        public List<FilmGenre> FilmGenre { get; set; }
        public string Fragman { get; set; }
     
         public IFormFile Photos { get; set; }
        [Required]
        public List<int> GenreId { get; set; }
        public List<Genre> Genres { get; set; }
    }
}
