using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int> nameAge = new Dictionary<string, int>();
            for (int i = 1; i <= n; i++)
            {
                string[] inputLine = Console.ReadLine().Split(new[] {", "},StringSplitOptions.RemoveEmptyEntries);
                nameAge.Add(inputLine[0], int.Parse(inputLine[1]));

            }
            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            switch (condition)
            {
                case "older":
                    {
                        PrintOlderList(nameAge,format, age);
                    }
                    break;
                case "younger":
                    {
                        PrintYoungerList(nameAge, format, age);

                    }
                    break;
            }
        }
        static void PrintOlderList(Dictionary<string, int> nameAge,string[] format,int age)
        {
            int personAge;
            if (format.Length == 2)
            {
                foreach (var person in nameAge.Where(n => n.Value >= age))
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
            else if (format[0]=="age")
            {
                foreach (var person in nameAge.Where(n => n.Value >= age))
                {
                    Console.WriteLine($"{person.Value}");
                }
            }
            else
            {
                foreach (var person in nameAge.Where(n => n.Value >= age))
                {
                    Console.WriteLine($"{person.Key}");
                }
            }
        }
        static void PrintYoungerList(Dictionary<string, int> nameAge, string[] format, int age)
        {
            int personAge;
            if (format.Length == 2)
            {
                foreach (var person in nameAge.Where(n => n.Value < age))
                {
                    Console.WriteLine($"{person.Key} - {person.Value}");
                }
            }
            else if (format[0] == "age")
            {
                foreach (var person in nameAge.Where(n => n.Value < age))
                {
                    Console.WriteLine($"{person.Value}");
                }
            }
            else
            {
                foreach (var person in nameAge.Where(n => n.Value < age))
                {
                    Console.WriteLine($"{person.Key}");
                }
            }
        }
    }
}
