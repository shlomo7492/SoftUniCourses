using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class CustomerCard
    {
        public CustomerCard()
        {
            CardType = "NORMAL";
        }
        public int Id { get; set; }

        [Required]
        [MaxLength(128)]
        public string Name { get; set; }

        [Range(0,120)]
        public int? Age { get; set; }
        public string CardType { get; set; }
    }
}
