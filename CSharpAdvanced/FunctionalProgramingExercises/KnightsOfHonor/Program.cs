using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> print = n => Console.WriteLine("Sir " + n);
            Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .ForEach(n => print(n));
        }
    }
}
