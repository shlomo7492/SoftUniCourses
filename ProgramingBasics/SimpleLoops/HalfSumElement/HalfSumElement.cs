using System;

namespace HalfSumElement
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int[] sequence = new int[n];
			int seqSum = 0; 
			int max = int.MinValue;
			bool equal = false;
			for (int i = 0; i < n; i++) 
			{
				sequence [i] = int.Parse (Console.ReadLine ());
				seqSum = seqSum + sequence [i];
				if (max <= sequence [i]) 
				{
					max = sequence [i];
				}
			}
			for (int i = 0; i < n; i++) 
			{
				if (sequence [i] == (seqSum - sequence [i])) 
				{
					equal = true;
					Console.WriteLine ("Yes\nSum = "+sequence[i]);
				}
			}
			if (equal == false) 
			{
				Console.WriteLine ("No\nDiff = "+Math.Abs((seqSum-max)-max));
			}
		}
	}
}
