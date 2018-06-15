using System;
using System.Numerics;

namespace BigFactorial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number = int.Parse (Console.ReadLine ());
			BigInteger bigNumber = 1;
			for (int i = 2; i <= number; i++) 
			{
				bigNumber *= i;
			}
			Console.WriteLine (bigNumber);
		}
	}
}
