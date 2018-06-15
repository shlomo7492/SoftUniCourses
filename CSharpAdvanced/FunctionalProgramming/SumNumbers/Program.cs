using System;
using System.Collections.Generic;
using System.Linq;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> numParser = n => int.Parse(n);
            Action<List<int>> count = n => Console.WriteLine(n.Count());
            Action<List<int>> sum = n => Console.WriteLine(n.Sum());
            var myList = Console.ReadLine().Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                                    .Select(numParser)
                                    .ToList();
            count(myList);
            sum(myList);
        }
    }
}
