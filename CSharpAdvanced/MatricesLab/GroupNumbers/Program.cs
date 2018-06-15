using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace GroupNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] numbers = new int[3][];
            int[] size = new int[3];
            int[] input = Regex.Split(Console.ReadLine(), ", ")
                                        .Select(int.Parse)
                                        .ToArray();
            foreach (var num in input)
            {
                size[Math.Abs(num) % 3]++;
            }
            numbers[0] = new int[size[0]];
            numbers[1] = new int[size[1]];
            numbers[2] = new int[size[2]];
            for (int i = 0; i < 3; i++)
            {
                int index = 0;
                foreach (var num in input.Where(x=>Math.Abs(x)%3==i))
                {
                    numbers[i][index] = num;
                    index++;
                }
            }
            for(int i=0;i<3;i++)
            {
                for (int k = 0; k < size[i]; k++)
                {
                    Console.Write(numbers[i][k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
