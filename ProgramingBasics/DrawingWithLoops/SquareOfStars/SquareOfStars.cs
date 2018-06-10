using System;

namespace SquareOfStars
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			for (int i = 1; i <= n; i++) 
			{
				for (int j = 1; j <= n - 1; j++) 
				{
					Console.Write ("* ");
				}
				Console.WriteLine ('*');
			}
		}
	}
}
