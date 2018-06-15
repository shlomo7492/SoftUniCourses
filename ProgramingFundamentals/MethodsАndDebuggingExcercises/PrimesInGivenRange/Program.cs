using System;

namespace PrimesInGivenRange
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong firstNum = ulong.Parse (Console.ReadLine ());
			ulong secondNum = ulong.Parse (Console.ReadLine ());
			PrintAllPrimeNumsInRange (firstNum, secondNum);
		}

		static bool PrimeNumsChecker (ulong number)
		{
			bool checkPrime = true;
			if (number <= 1ul) 
			{
				checkPrime = false;
			}
			for (ulong i = 2; i <= Math.Sqrt (number); i++) 
			{
				if (number % i == 0)
				{
					checkPrime = false;
					break;
				}
			}
			return checkPrime;
		}

		static void PrintPrimeNum(ulong number)
		{
			if (PrimeNumsChecker(number))
				{
					Console.Write("{0}",number);
				}
		}
		static void PrintAllPrimeNumsInRange(ulong firstNum,ulong secondNum)
		{
			int count = 0;
			for (ulong i = firstNum; i <= secondNum; i++) 
			{
				if (PrimeNumsChecker(i)) 
				{
					count++;
					if (count > 1)
					{
						Console.Write (", ");
					}
				}
				PrintPrimeNum (i);
			}
		}
	}
}
