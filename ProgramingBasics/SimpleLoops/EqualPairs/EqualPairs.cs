using System;

namespace EqualPairs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var n = int.Parse (Console.ReadLine ());
			int[] pairSum = new int[n];
			int[] numbers = new int[(2 * n)];
			int diffMax = 0;
			for (int i = 0; i < 2 * n; i++) 
			{
				numbers[i] = int.Parse (Console.ReadLine ());

				if ((i >= 1) && (i % 2 != 0))
				{
					pairSum [i / 2] = numbers[i]+numbers[i-1];
					Console.WriteLine (pairSum [i / 2]);
				}
				if (((i / 2) > 0) && (i % 2 != 0) && (Math.Abs(pairSum [i / 2] - pairSum [(i / 2)-1]) >= diffMax))
				{
					diffMax= Math.Abs(pairSum [i / 2]-pairSum [(i / 2) - 1]);
				}
			}

			if (diffMax == 0)
			{			
				Console.WriteLine ("Yes, value="+pairSum[0]);
			} 
			else 
			{
				Console.WriteLine ("No, maxdiff="+ diffMax);				
			}
		}
	}
}
