using System;

namespace SumNums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());
			var oddSum = 0;
			var evenSum = 0;
			for (int i = 1; i <= n; i++) 
			{
				var currentNum = int.Parse (Console.ReadLine ());
				if ((i % 2) == 0) 
				{
					evenSum = evenSum + currentNum;
				}
				else
				{
					oddSum = oddSum + currentNum;

				}
			}

			if (Math.Abs (oddSum - evenSum) == 0) 
			{
				Console.WriteLine("Yes \nSum = "+oddSum);
			} 
			else 
			{
				Console.WriteLine("No\nDiff = " + Math.Abs (oddSum - evenSum) );
			}
		}
	}
}
