using System;

namespace SumNums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());
			var oddSum = 0f;
			var evenSum = 0f;
			var oddMax = float.MinValue;
			var evenMax = float.MinValue;
			var oddMin = float.MaxValue;
			var evenMin = float.MaxValue;
			for (int i = 1; i <= n; i++) 
			{
				float currentNum = float.Parse (Console.ReadLine ());
				if ((i % 2) == 0) 
				{
					evenSum = evenSum + currentNum;
					if (evenMax <= currentNum)
					{
						evenMax = currentNum;
					} 
					if (evenMin >= currentNum) 
					{
						evenMin = currentNum;
					}
				}
				else
				{
					oddSum = oddSum + currentNum;
					if (oddMax <= currentNum)
					{
						oddMax = currentNum;
					} 
					if (oddMin >= currentNum) 
					{
						oddMin = currentNum;
					}
				}
			}

			if (oddSum == 0) 
			{
				Console.WriteLine ("OddSum={0},\nOddMin={1},\nOddMax={1},\nEvenSum={2},\nEvenMin={1},\nEvenMax={1}", oddSum, "No", evenSum);
			}
			else if (evenSum == 0) 
			{
				Console.WriteLine ("OddSum={0},\nOddMin={1},\nOddMax={2},\nEvenSum={3},\nEvenMin={4},\nEvenMax={4}", oddSum, oddMin, oddMax, evenSum, "No");
			} 
			else
			{
				Console.WriteLine ("OddSum={0},\nOddMin={1},\nOddMax={2},\nEvenSum={3},\nEvenMin={4},\nEvenMax={5}", oddSum, oddMin, oddMax, evenSum, evenMin,evenMax);
			}
		}
	}
}
