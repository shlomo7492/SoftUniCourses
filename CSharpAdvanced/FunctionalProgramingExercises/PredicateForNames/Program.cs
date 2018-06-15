using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int len = int.Parse(Console.ReadLine());

            Func<string,bool> compare = str => str.Length <= len;

            Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(n=>n)
                              .Where(compare)
                              .ToList()
                              .ForEach(n => Console.WriteLine(n));

        }
    }
}
