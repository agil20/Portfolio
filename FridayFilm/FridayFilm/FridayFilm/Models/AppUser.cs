using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FridayFilm.Models
{
    public class AppUser:IdentityUser
    {
      
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Comment> Comments { get; set; }

        public bool Abune { get; set; } 
        public int Balance { get; set; }
        public DateTime AbuneStard { get; set; }
        public DateTime AbuneEnd { get; set; }


    }
}
