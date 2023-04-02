﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public DateTime SaleDate { get; set; }
        public int Total { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    
        public List<SalesProduct> SalesProducts { get; set; }

    }
}
