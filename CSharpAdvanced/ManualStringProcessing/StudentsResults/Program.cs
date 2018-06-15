using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, double[]> studentsResults = new Dictionary<string, double[]>();
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int index = input.IndexOf(' ');
                string name = input.Substring(0, index);
                
                double[] results = input.Substring(index, input.Length-index)
                                     .Split(new[] { " - ", ", " }, StringSplitOptions.RemoveEmptyEntries)
                                     .Select(double.Parse)
                                     .ToArray();
                studentsResults.Add(name, results);
            }

            Console.WriteLine("{0,-10}|{1,7}|{2,7}|{3,7}|{4,7}|","Name","CAdv","COOP","AdvOOP","Average");
            foreach (var student in studentsResults)
            {

                //Console.WriteLine(string.Format("{ 0,-10}|{ 1,7:f2}|{ 2,7:f2}|{ 3,7:f2}|{ 4,7:f4}|", student.Key, student.Value[0], student.Value[1], student.Value[2], student.Value.Average()));
                Console.WriteLine($"{student.Key,-10}|{student.Value[0],7:f2}|{student.Value[1],7:f2}|{student.Value[2],7:f2}|{student.Value.Average(),7:f4}|");
            }
        }
    }
}
