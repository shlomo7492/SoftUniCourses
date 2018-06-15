using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomMInFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<List<int>, int> minFunc = n => n.Min();
            Console.WriteLine(minFunc(Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList()));
        }
    }
}
