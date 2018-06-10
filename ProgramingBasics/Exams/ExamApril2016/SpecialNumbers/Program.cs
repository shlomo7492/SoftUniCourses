using System;

namespace SpecialNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			for (int one = 1; one <= 9; one++) 
			{
				for (int two = 1; two <= 9; two++) 
				{
					for (int three = 1; three <= 9; three++) 
					{
						for (int four = 1; four <= 9; four++) 
						{
							if ((n % one == 0) && (n % two == 0) && (n % three == 0) && (n % four == 0)) 
							{
								Console.Write ("{0}{1}{2}{3} ",one,two,three,four);
							}
						}
					}
				}
			}
		}
	}
}
