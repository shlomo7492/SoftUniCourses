using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTOS.Imports
{
    public class TrainSeatsDTO
    {
        public string TrainTrainNumber { get; set; }
        public string Type { get; set; }
        public List<SeatDTO> Seats { get; set; }
    }
    public class SeatDTO
    {
        public string SeatClassName { get; set; }
        public string Abbreviation { get; set; }
        public int Quantity { get; set; }
    }
}
