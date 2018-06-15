using System;

namespace MultiplyEvensByOdds
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string number = Console.ReadLine ();
			Console.WriteLine (MultiplyEvenByAllDigits(number));
		}
		static int SumEvenDigits (string number)
		{
			int evenDigs = 0;
			int start = 0;
			if (number [0] == '-') 
			{
				start = 1;
			}
			for (int i = start; i <= number.Length - 1; i++) 
			{
				int tempDigit = int.Parse (number [i] + "");
				if (tempDigit % 2 == 0) 
				{
					evenDigs += tempDigit;
				}
			}
			return evenDigs;
		}
		static int SumAllDigits (string number)
		{
			int allDigs = 0;
			int start = 0;
			if (number [0] == '-') 
			{
				start = 1;
			}
			for (int i = start; i <= number.Length - 1; i++) 
			{
				int tempDigit = int.Parse (number [i] + "");
				if (tempDigit % 2 != 0) 
				{
					allDigs += tempDigit;
				}
			}
			return allDigs;
		}
		static int MultiplyEvenByAllDigits (string number)
		{
			return SumEvenDigits (number) * SumAllDigits (number);
		}

	}
}
