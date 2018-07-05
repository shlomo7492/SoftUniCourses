using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Homework
    {
        public Homework(string contentType)
        {
            ContentType = contentType;
        }
        private string contentType;
        [Key]
        public int HomeworkId { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string ContentType
        {
            get
            {
                return this.contentType;
            }
            set
            {
                if ((value == "application") || (value == "pdf") || (value == "zip"))
                {
                    throw new ArgumentException
                    (string.Format
                    ("This homework is not in correct format::",
                    value));
                }
                else
                {
                    this.contentType = value;
                }
            }
        }
        [Required]
        public DateTime SubmissionDate { get; set; }

        public virtual Student Student { get; set; }

    }
}
