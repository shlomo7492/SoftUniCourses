using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataBase.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public double Quantity { get; set; }
        public decimal Price { get; set; }
        public List<Sale> Sales { get; set; }
    }
}
