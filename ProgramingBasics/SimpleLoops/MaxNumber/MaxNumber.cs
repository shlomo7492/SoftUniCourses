using System;

namespace MaxNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());
			var max = int.MinValue;
			for (int i = 1; i <= n; i++) 
			{
				var currentNum = int.Parse (Console.ReadLine ());
				if (max <= currentNum) 
				{
					max = currentNum;
				}
			}
			Console.WriteLine (max);		
		}
	}
}
