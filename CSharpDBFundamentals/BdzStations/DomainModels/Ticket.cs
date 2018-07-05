using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class Ticket
    {
        public int Id { get; set; }

        public int TripId { get; set; }
        [Required]
        public Trip Trip { get; set; }

        [Required]
        public decimal Price  { get; set; }

        [Required]
        [MaxLength(8)]
        public string SeatingPlace { get; set; }

        public int PersonalCardId { get; set; }
        public CustomerCard PersonalCard { get; set; }
    }
}
