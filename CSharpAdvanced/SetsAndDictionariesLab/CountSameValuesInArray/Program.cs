using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();
            double[] inputArray = Console.ReadLine()
                                            .Split(new char[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                                            .Select(double.Parse)
                                            .ToArray();
            foreach(double number in inputArray)
            {
                if(counts.ContainsKey(number))
                {
                    counts[number]++;
                }
                else
                {
                    counts.Add(number, 1);
                }
            }
            foreach (var element in counts)
            {
                Console.WriteLine($" {element.Key} - {element.Value} times");
            }
        }
    }
}
