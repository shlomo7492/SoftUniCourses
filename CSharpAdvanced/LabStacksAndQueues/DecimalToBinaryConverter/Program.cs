using System;
using System.Collections.Generic;

namespace DecimalToBinaryConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> binaryNum = new Stack<int>();
            int number = int.Parse(Console.ReadLine());
            if (number == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                while (number >= 1)
                {
                    binaryNum.Push((number % 2));
                    number /= 2;
                }
            }
            var lim = binaryNum.Count;
            for (int i = 0; i < lim; i++)
            {
                Console.Write(binaryNum.Pop());
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
