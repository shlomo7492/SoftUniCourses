using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGraduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputs = int.Parse(Console.ReadLine());
            SortedDictionary<string, double> studentResult = new SortedDictionary<string, double>();

            for (int i=1;i<=inputs;i++)
            {
                string name = Console.ReadLine();
                double averageScore = Console.ReadLine()
                                        .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                        .Select(double.Parse)
                                        .ToArray()
                                        .Average();
                studentResult.Add(name, averageScore);
            }
            foreach (var result in studentResult)
            {
                Console.WriteLine($"{result.Key} is graduated with {result.Value}");
            }
        }
    }
}
