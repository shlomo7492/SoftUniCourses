using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persons;

namespace StudentsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();

            while (strInput.ToLower() != "end")
            {
                Student student =new Student();
                student.Name = strInput;
                strInput = Console.ReadLine();
            }
            Console.WriteLine(Student.count);
        }
    }
}
