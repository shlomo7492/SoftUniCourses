using System;
using System.Linq;

namespace EqualSums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] numbers = Console.ReadLine ().Split ().Select (x => int.Parse (x)).ToArray ();
			bool equalLeftAndRightSum = false;
			int index = 0;
			for (int i = 0; i < numbers.Length; i++) 
			{
				if (numbers.Length==1) 
				{
					Console.WriteLine (index);
				}
				else
				{
					int leftSum = 0;
					int rightSum = 0;
					for (int k = 0; k < i; k++) 
					{
						leftSum += numbers [k];
					}
					for (int k = i+1; k < numbers.Length; k++) 
					{
						rightSum += numbers [k];
					}
					if (leftSum == rightSum)
					{
						equalLeftAndRightSum = true;
						index = i;
					} 

				}

			}
			if (equalLeftAndRightSum) 
			{
				Console.WriteLine ($"{index}");
			} 
			else if (numbers.Length > 1)
			{
				Console.WriteLine ("no");
			}

		}
	}
}
