using System;

namespace CheckPrime
{
	class SimpleNumber
	{
		public static void Main (string[] args)
		{
			//Console.WriteLine ("This program will check if the number entered from keyboar is simple.");
			int numSimple = int.Parse (Console.ReadLine ());

			int reminder = 0;

			for (int i=1; i <= Math.Sqrt(numSimple); i++) 
			{
				if ((numSimple % i) == 0) 
				{
					reminder++;
					Console.WriteLine (reminder);
				}		
			}
			if ((reminder <= 1) && (numSimple > 1)) 
			{
				Console.WriteLine ("Prime");
			}
			else
			{
				Console.WriteLine ("Not Prime");
			}
		}
	}
}