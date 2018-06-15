using System;
using System.Linq;

namespace SortEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> numParser = n => int.Parse(n);
            Console.WriteLine( string.Join(", ", Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(numParser)
                                    .Where(n => n % 2 == 0)
                                    .OrderBy(n => n)
                                    .ToList()));
        }
    }
}
