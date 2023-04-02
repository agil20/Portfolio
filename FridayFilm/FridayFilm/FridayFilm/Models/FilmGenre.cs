﻿using System.Collections.Generic;

namespace FridayFilm.Models
{
    public class FilmGenre
    {
        public int Id { get; set; }

        public int FilmId { get; set; }
        public int GenreId { get; set; }
        public Film Film { get; set; }
        public Genre Genre { get; set; }
       



    }
}
