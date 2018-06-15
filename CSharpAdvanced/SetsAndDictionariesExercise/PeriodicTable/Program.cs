using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> elements = new List<string>();
            for(int i=1;i<=n;i++)
            {
                string[] input = Console.ReadLine()
                                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string element in input)
                {
                    if(!elements.Contains(element))
                    {
                        elements.Add(element);
                    }
                }
            }
            elements = elements.OrderBy(x => x)
                               .ToList();
            foreach (string element in elements)
            {
                Console.Write (element+ " ");
            }
        }
    }
}
