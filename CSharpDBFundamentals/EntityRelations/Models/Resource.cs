using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Resource
    {
        public Resource(string resourceType)
        {
            ResourceType = resourceType;
        }
        private string resourceType;
        [Key]
        public int ResourceId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string ResourceType {
            get
            {
                return this.resourceType;
            }
            set
            {
                if ((value == "video") || (value == "presentation") || (value == "document") || (value == "other"))
                {
                    throw new ArgumentException
                    (string.Format
                    ("Unknown Resource type::",
                    value));
                }
                else
                {
                    this.resourceType = value;
                }
            }
        }
        [Required]
        public string Url { get; set; }
        
      
    }
}
