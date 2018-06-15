using System;
using System.Collections.Generic;
using System.Numerics;

namespace ConvertNToTen
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] command = Console.ReadLine()
                        .Split(' ');
            int numBase = int.Parse(command[0]);
            Stack<int> number = new Stack<int>();
            foreach (var chr in command[1])
            {
                number.Push(int.Parse(chr+""));
            }
            BigInteger converted = 0;
            for(int i=0;i<command[1].Length;i++)
            {
                converted += number.Pop()*BigInteger.Pow(numBase, i);
            }
            Console.WriteLine(converted);
        }
    }
}
