using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrontToBack.Models
{
    public class SalesProduct
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Count { get; set; }
        public int SaleId { get; set; }
        public Sale Sale { get; set; }
        public int Price { get; set; }
    }
}
