using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataBase.Models
{
    public class Sale
    {
        public int SaleId { get; set; }
        public Product Product { get; set; }
        public Customer Customer { get; set; }
        public StoreLocation StoreLocation { get; set; }
        public DateTime Date { get; set; }
    
    }
}
