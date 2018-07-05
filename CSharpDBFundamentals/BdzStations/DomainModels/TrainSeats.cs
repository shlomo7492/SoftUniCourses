using System.ComponentModel.DataAnnotations;

namespace DomainModels
{
    public class TrainSeats
    {

        public int TrainId { get; set; }
        [Required]
        public Train Train { get; set; }

        public int SeatClassId { get; set; }

        [Required]
        public SeatingClass SeatClass { get; set; }

        [Required]
        public int Quantity { get; set; }

        public class Where
        {
            public Where()
            {
            }
        }
    }
}
