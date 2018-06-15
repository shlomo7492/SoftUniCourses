using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var inputStudent = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Student student = new Student(inputStudent[0], inputStudent[1], inputStudent[2]);

                var inputWorker = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                Worker worker = new Worker(inputWorker[0], inputWorker[1], decimal.Parse(inputWorker[2]), decimal.Parse(inputWorker[3]));

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (ArgumentException excp)
            {
                Console.WriteLine(excp.Message);
            }
        }

    }
}
