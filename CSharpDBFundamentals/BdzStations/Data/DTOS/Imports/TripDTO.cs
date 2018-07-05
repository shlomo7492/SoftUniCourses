using DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOS.Imports
{
    public class TripDTO
    {
        public string Train { get; set; }
        public Station OriginStation { get; set; }

        public Station DestinationStation { get; set; }

        public DateTime DepartureTime { get; set; }

        public DateTime ArrivalTime { get; set; }
     
        public string Status { get; set; }
    }
}
