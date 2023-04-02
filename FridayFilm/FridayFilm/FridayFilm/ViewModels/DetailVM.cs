using FridayFilm.Models;
using System.Collections.Generic;

namespace FridayFilm.ViewModels
{
    public class DetailVM
    {
        public Film film { get; set; }
        public List<Film> Films { get; set; }
    }
}
