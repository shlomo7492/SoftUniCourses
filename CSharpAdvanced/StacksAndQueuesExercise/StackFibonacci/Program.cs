using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<ulong> fibonacci = new Stack<ulong>();
            int fNum = int.Parse(Console.ReadLine());
            for (int i = 0; i <= fNum; i++)
            {
                if (i == 0 || i == 1)
                {
                    fibonacci.Push((ulong)i);
                }
                else
                {
                    var first = fibonacci.Pop();
                    var second = fibonacci.Pop() + first;
                    fibonacci.Push(first);
                    fibonacci.Push(second);
                }
            }
            Console.WriteLine(fibonacci.Pop());
        }
    }
}
