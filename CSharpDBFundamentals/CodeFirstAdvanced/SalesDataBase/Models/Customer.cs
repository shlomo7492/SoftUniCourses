﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesDataBase.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public string CreditCardNumber { get; set; }
        public ICollection<Sale> SalesForCustomer { get; set; }
    }
}
