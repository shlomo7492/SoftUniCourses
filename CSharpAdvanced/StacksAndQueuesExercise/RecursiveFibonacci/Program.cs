using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveFibonacci
{
    class Program
    {
        private static ulong[] fibonacci;

        static void Main(string[] args)
        {
            int nFibonacci = int.Parse(Console.ReadLine());
            fibonacci = new ulong[nFibonacci];
            Console.WriteLine(getFibonacci(nFibonacci));
            
        }
        static ulong getFibonacci(int n)
        {
            if (n <= 2)
            {
                return 1;
            }
            if (fibonacci[n - 1] != 0)
            {
                return fibonacci[n - 1];
            }
            return   fibonacci[n-1] = getFibonacci(n - 1) + getFibonacci(n - 2);
        }
    }
}
