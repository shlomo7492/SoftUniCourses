using System;

namespace PowersOfTwo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int power = 1;
			Console.WriteLine (power);
			for (int i = 1; i <= n; i ++) 
			{
				power = power * 2;
				Console.WriteLine (power);
			}
		}
	}
}
