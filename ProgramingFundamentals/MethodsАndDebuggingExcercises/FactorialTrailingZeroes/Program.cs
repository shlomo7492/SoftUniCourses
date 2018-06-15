using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace FactorialTrailingZeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            PrintTrailingZeroesInFactorial(endNum);
        }
        static BigInteger GetFactorial(int endNum)
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= endNum; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static string BigIntToString(BigInteger number) 
        { 
            return (""+number);
        }
        static void PrintTrailingZeroesInFactorial(int endNum)
        {
            string number = BigIntToString(GetFactorial(endNum));
            int countTrailingZeroes = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] != '0')
                {
                    break;
                }
                else 
                {
                    countTrailingZeroes++;
                }
            }
            if (countTrailingZeroes != 0)
            {
                if (countTrailingZeroes > 1)
                {
                    Console.WriteLine(countTrailingZeroes);
                }
                else
                {
                    Console.WriteLine(countTrailingZeroes);
                }
            }
            else
            {
                Console.WriteLine(countTrailingZeroes);
            }
        }
    }
}
