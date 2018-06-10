using System;

namespace SumNums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());
			var leftSum = 0;
			var rightSum = 0;
			for (int i = 1; i <= n; i++) 
			{
				var currentNum = int.Parse (Console.ReadLine ());
				leftSum = leftSum + currentNum;
			}
			for (int i = 1; i <= n; i++) 
			{
				var currentNum = int.Parse (Console.ReadLine ());
				rightSum = rightSum + currentNum;
			}
			if (Math.Abs (leftSum - rightSum) == 0) 
			{
				Console.WriteLine("Yes, sum = "+leftSum);
			} 
			else 
			{
				Console.WriteLine("No, diff = " + Math.Abs (leftSum - rightSum) );
			}
		}
	}
}
