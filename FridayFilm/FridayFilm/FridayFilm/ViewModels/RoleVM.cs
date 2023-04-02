﻿using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FridayFilm.ViewModels
{
    public class RoleVM
    {
        public string FullName { get; set; }
        public List<IdentityRole> Roles { get; set; }
        public IList<string> UserRoles { get; set; }
        public string UserId { get; set; }
    }
}
