using System;

namespace EvenPowersOfTwo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int power = 1;
			Console.WriteLine (power);
			for (int i = 2; i <= n; i +=2) 
			{
				power = power * 4;
				Console.WriteLine (power);
			}
		}
	}
}
