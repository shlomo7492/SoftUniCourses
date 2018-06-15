using System;

namespace PrimeChecker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong number = ulong.Parse (Console.ReadLine ());
			Console.WriteLine (PrimeNumsChecker (number));
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
	}
}
