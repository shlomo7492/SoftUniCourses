using System;

namespace House
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			if (n % 2 == 0) 
			{
				for (int i = 1; i <= n / 2; i++)
				{
					Console.WriteLine ((new string ('-', (n/2-i))) + (new string ('*', 2*i)) + (new string ('-', (n/2-i))));
				}

			} 
			else 
			{
				for (int i = 1; i <= ((n+1) / 2); i++)
				{	
					Console.WriteLine ((new string ('-', ((n+1)/2-i))) + (new string ('*',n-(2*((n+1)/2-i)))) + (new string ('-', ((n+1)/2-i))));
				}

			} 
			for (int i = 1; i <= n / 2; i++)
			{	
				Console.WriteLine ("|" + (new string ('*',n-2)) + "|");
			}
		}
	}
}
