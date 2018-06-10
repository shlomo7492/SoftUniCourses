using System;

namespace RectangleOfTenByTenStars
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			string row = new string ('*', n);
			for (int i = 1; i <= n; i++) 
			{
				Console.WriteLine (row);
			}
		}
	}
}
