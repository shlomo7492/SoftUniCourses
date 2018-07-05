using System.ComponentModel.DataAnnotations;

namespace DomainModels
{
    public class Planet
    {
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        private double mass;
        [Required]
        public double Mass
        {
            get
            {
                return mass;
            }
            set
            {
                if (value > 0)
                {
                    this.mass = value;
                }
                else
                {
                    this.mass = double.Epsilon;
                }

            }
        }
        public int HostStarSystemId { get; set; }
        [Required]
        public virtual StarSystem HostStarSystem { get; set; }

    }
}
