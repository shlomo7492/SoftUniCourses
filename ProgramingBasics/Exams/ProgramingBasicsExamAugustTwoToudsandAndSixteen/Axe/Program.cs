using System;

namespace Axe
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			for (int i = 0; i < n; i++) 
			{
				Console.WriteLine((new string('-',3*n))+"*"+(new string('-',i))+"*"+(new string('-',(2*(n-1))-i)));
			}
			for (int i = 1; i <= n / 2; i++) 
			{
				Console.WriteLine((new string('*',3*n+1))+(new string('-',n-1))+"*"+(new string('-',n-1)));

			}
			if (n > 2) 
			{
				Console.WriteLine ((new string ('-', 3 * n)) + "*" + (new string ('-', n - 1)) + "*" + (new string ('-', n - 1)));
			}

			for (int i = 1; i <= (n / 2) - 1; i++) 
			{
				if (i < (n / 2) - 1) {
					Console.WriteLine ((new string ('-', 3 * n - i)) + "*" + (new string ('-', (n - 1) + (i * 2))) + "*" + (new string ('-', (n - 2) - (i - 1))));
				} 
				else 
				{
					if (n % 2 == 0) 
					{
						Console.WriteLine ((new string ('-', 5 * n - ((2 * n - 1) + n / 2))) + (new string ('*', 2 * n - 1)) + (new string ('-', n / 2)));
					} 
					else 
					{
						Console.WriteLine ((new string ('-', 3 * n - i)) + "*" + (new string ('*', (n - 1) + (i * 2))) + "*" + (new string ('-', (n - 2) - (i - 1))));

					}
				}
			}

		}
	}
}
