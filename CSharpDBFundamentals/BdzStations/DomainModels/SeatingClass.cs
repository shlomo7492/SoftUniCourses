using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModels
{
    public class SeatingClass
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        [Index(IsUnique = true)]
        public string  Name { get; set; }

        [Required]
        [MinLength(2),MaxLength(2)]
        public string Abbreviation  { get; set; }
    }
}
