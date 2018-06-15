using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray();
            int n = input[0];
            int m = input[1];
            int[] numbers = new int[n + m];
            for (int i=0;i<numbers.Length;i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            HashSet<int> nNumbers = new HashSet<int>();
            HashSet<int> mNumbers = new HashSet<int>();

            for (int i=0;i<n;i++)
            {
                if (!nNumbers.Contains(numbers[i]))
                {
                    nNumbers.Add(numbers[i]);
                }
            }
            for (int i = n; i < n+m; i++)
            {
                if (!mNumbers.Contains(numbers[i]))
                {
                    mNumbers.Add(numbers[i]);
                }
            }
            foreach (var num in nNumbers)
            {
                if(mNumbers.Contains(num))
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
