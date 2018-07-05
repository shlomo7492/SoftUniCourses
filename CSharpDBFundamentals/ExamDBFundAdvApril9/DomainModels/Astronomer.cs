using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class Astronomer
    {
        public Astronomer()
        {
            this.PioneeringDiscoveries = new HashSet<Discovery>();
            this.ObservedDiscoveries = new HashSet<Discovery>();
        }
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string FirstName { get; set; }

        [StringLength(50)]
        [Required]
        public string LastName { get; set; }

        [InverseProperty("Pioneers")]
        public virtual ICollection<Discovery> PioneeringDiscoveries { get; set; }

        [InverseProperty("Observers")]
        public virtual ICollection<Discovery> ObservedDiscoveries { get; set; }
    }
}
