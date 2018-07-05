using System.ComponentModel.DataAnnotations;

namespace DomainModels
{
    public class Star
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        private int temperature;
        [Required]
        public int Temperature
        {
            get
            {
                return temperature;
            }
            set
            {
                if (value > 2400)
                {
                    this.temperature = value;
                }
                else
                {
                    this.temperature = 2400;
                }

            }
        }
        public int HostStarSystemId { get; set; }
        [Required]
        public virtual StarSystem HostStarSystem { get; set; }
    }
}
