using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DomainModels
{
    public class Discovery
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateMade { get; set; }

        public int TelescopeUsedId { get; set; }
        [Required]                  
        public virtual Telescope TelescopeUsed { get; set; }

        public virtual ICollection<Star> Stars { get; set; }
        public virtual ICollection<Planet> Planets { get; set; }

        public virtual ICollection<Astronomer> Pioneers  { get; set; }
        public virtual ICollection<Astronomer> Observers { get; set; }


    }
}
