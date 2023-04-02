﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontToBack.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int Count { get; set; }
        public List<SalesProduct> SalesProducts { get; set; }



    }
}
