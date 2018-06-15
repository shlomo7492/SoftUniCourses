using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConvertFromTenToN
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                                    .Split(' ');
            int numBase = int.Parse(command[0]);
            BigInteger number = BigInteger.Parse(command[1]);
            BigInteger result = number;
            Stack<int> converted = new Stack<int>();
            while(result!=0)
            {
                converted.Push((int)(result % numBase));
                result /= numBase;
            }
            Console.WriteLine(string.Join("",converted));
        }
    }
}
