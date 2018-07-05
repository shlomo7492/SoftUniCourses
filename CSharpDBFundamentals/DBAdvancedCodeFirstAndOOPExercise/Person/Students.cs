using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    public class Student
    {
        public static int count;

        public Student()
        {
            count++;
        }
        public string Name { get; set; }
    }
}
