using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public decimal Price { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Resource> Resourses { get; set; }
        public virtual ICollection<Homework> Homeworks { get; set; }



    }
}
