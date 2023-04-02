using System;
using System.Collections.Generic;

namespace FridayFilm.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Text { get; set; }
        public Film Film { get; set; }
        public int  FilmId { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
        public DateTime CreateComment { get; set; }
    





    }
}
