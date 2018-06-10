using System;

namespace MaxNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());
			var min = int.MaxValue;
			for (int i = 1; i <= n; i++) 
			{
				var currentNum = int.Parse (Console.ReadLine ());
				if (min >= currentNum) 
				{
					min = currentNum;
				}
			}
			Console.WriteLine (min);		
		}
	}
}
