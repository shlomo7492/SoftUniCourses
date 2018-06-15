using System;

namespace ExactSumОfRealNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int numbCount = int.Parse (Console.ReadLine ());
			decimal sum = 0m;
			for (int i = 1; i <= numbCount; i++) 
			{
				sum += decimal.Parse (Console.ReadLine ());
			}
			Console.WriteLine (sum);
		}
	}
}
