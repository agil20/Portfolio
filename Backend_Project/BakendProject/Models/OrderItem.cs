﻿namespace BakendProject.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public double Total { get; set; }
        public int Count { get; set; }
  
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string ImageUrl { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}
