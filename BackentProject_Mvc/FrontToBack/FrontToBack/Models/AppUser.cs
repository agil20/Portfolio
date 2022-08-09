using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace FrontToBack.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public DateTime UserCreateTime { get; set; }
        public DateTime ConfirMailTime { get; set; }
        public List<Sale> Sales { get; set; }
        
    }
}
