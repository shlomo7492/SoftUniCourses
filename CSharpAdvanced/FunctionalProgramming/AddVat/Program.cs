using System;
using System.Linq;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, double> doubleParse = n => double.Parse(n);
            Action<double> printPlusVat = n => Console.WriteLine($"{n*1.2:f2}");
            Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(doubleParse)
                              .ToList()
                              .ForEach(n => printPlusVat(n));
        }
    }
}
