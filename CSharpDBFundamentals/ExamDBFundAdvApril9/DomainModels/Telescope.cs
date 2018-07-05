using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainModels
{
    public class Telescope
    {
        public Telescope()
        {
            this.Discoveries = new HashSet<Discovery>();
        }
        public int Id { get; set; }

        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [StringLength(255)]
        [Required]
        public string Location { get; set; }

        private double? mirrorDiameter;
        public double? MirrorDiameter
        {
            get
            {
                return mirrorDiameter;
            }
            set
            {
                if (value > 0)
                {
                    this.mirrorDiameter = value;
                }
            }
        }
        public virtual ICollection<Discovery> Discoveries { get; set; }
    }
}
