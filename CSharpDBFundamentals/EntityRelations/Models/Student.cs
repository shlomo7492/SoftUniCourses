using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {
        public Student()
        {

        }

        [Key]
        public int StudentId { get; set; }

        [Required]
        public string Name{ get; set; }
        public string  PhoneNumber { get; set; }

        [Required]
        public DateTime RegisteredOn { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual ICollection<Course> Courses { get; set;}
    }
}
