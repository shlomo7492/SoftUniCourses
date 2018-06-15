using System;

namespace TriplesOfLatinLetters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			for (int i = 0; i < n; i++) 
			{
				for (int j = 0; j < n; j++) 
				{
					for (int k = 0; k < n; k++) 
					{
						char one = (char)('a' + i);
						char two = (char)('a' + j);
						char three = (char)('a' + k);
						Console.WriteLine ("{0}{1}{2}",one,two,three);
					}
				}
			}
		}
	}
}
