using FridayFilm.Models;
using System.Collections.Generic;

namespace FridayFilm.ViewModels
{
    public class ProfileVM
    {
 
        public List<Comment> Comments { get; set; }
        public AppUser AppUser { get; set; }
    }
}
