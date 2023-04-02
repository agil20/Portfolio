using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FridayFilm.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public int IMDB { get; set; }
        public string Desc { get; set; }
        public string Countr { get; set; }
        public string RealeaseYear { get; set; }
        public string RunnigTime { get; set; }
        public string AgeLimit { get; set; }
        public List<Comment> Comments { get; set; }
        public List<FilmGenre> FilmGenre { get; set; }
        public string Fragman { get; set; }
        public bool IsDelete { get; set; }
        public string FilmUrl { get; set; }
        public DateTime CreateTime { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }



    }
}
