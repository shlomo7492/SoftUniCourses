using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels
{
    public class Trip
    {
        public Trip()
        {
            Status = "ONTIME";
        }
        public int Id { get; set; }

        [Required]
        public Station StationOfOrigin { get; set; }

        [Required]
        public Station StationOfDestination { get; set; }

        [Required]
        public DateTime DepartureTime { get; set; }

        [Required]
        public DateTime ArrivalTime { get; set; }

        [Required]
        public Train Train { get; set; }
        public string Status { get; set; }
        public TimeSpan TimeDifference { get; set; }

    }
}
