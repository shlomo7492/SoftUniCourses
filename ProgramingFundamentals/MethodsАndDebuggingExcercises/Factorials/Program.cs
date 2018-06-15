using System;
using System.Numerics;


namespace Factorials
{
	class MainClass
	{
		public static void Main (string[] args)
		{
            int endNum = int.Parse(Console.ReadLine());
            PrintFactorial(endNum);
		}
        static BigInteger GetFactorial(BigInteger endNum) 
        {
            BigInteger factorial = 1;

            for (int i = 1; i <= endNum; i++) 
            {
                factorial *= i;
            }
            return factorial;
        }
        static void PrintFactorial(int endNum) 
        {
            Console.WriteLine(GetFactorial(endNum));
        }
	}
}
