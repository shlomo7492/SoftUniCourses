using System;

namespace calculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong number = 549755811839;
			for (int i = 39; i <= 54; i++) 
			{
				number += (ulong)Math.Pow (2, i);
			}
			Console.WriteLine ("{0:d20}",number);
			Console.WriteLine("{0:d20}",18014398509414399*2);

		}
	}
}
