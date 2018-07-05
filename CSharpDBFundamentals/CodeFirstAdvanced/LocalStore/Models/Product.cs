using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalStore.Models
{
    public class Product
    {
        public Product(string name,string distributor,string description,double weight,int quantity, decimal price)
        {
            this.Name = name;
            this.Distributor = distributor;
            this.Description = description;
            this.Price = price;
            this.Weight = weight;
            this.Quantity = quantity;
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Distributor { get; set; }
        public string Description { get; set; }
      
        //weight and quantity are added in task two
        public double Weight { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}
