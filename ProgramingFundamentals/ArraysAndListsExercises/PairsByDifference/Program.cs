using System;
using System.Linq;

namespace PairsByDifference
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = Console.ReadLine ().Split ().Select (x => int.Parse (x)).ToArray ();
			int howDifferent = int.Parse (Console.ReadLine ());
			int differencies = 0;
			for (int i = 0; i < numbers.Length; i++) 
			{
				for (int k = i+1; k < numbers.Length; k++) 
				{
					if (Math.Abs (numbers [i] - numbers [k]) == howDifferent) 
					{
						differencies++;
					}
					
				}
			}
			Console.WriteLine (differencies);
		}
	}
}
