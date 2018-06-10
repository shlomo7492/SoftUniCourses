using System;

namespace Diamond
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			if (n % 2 == 0) 
			{
				for (int i = 1; i <= (n+1) / 2; i++)
				{
					Console.WriteLine ((new string ('-', (n/2-i))) + "*"+(new string ('-',2*i-2)) + "*"+(new string ('-', (n/2-i))));
				}
				for (int i = 2; i <= (n / 2); i++)
				{
					Console.WriteLine ((new string ('-', i-1)) + "*"+(new string ('-',(n-2)-(2*i-2))) + "*"+(new string ('-', i-1)));
				}

			} 
			else 
			{	
				Console.WriteLine ((new string ('-', ((n+1)/2-1))) + "*" + (new string ('-', ((n+1)/2-1))));
				
				for (int i = 1; i <= ((n+1) / 2)-1; i++)
				{	
					Console.WriteLine ((new string ('-', ((n+1)/2-(i+1)))) + "*"+(new string ('-',n-(2*((n+1)/2-i)))) + "*"+(new string ('-', ((n+1)/2-(i+1)))));
				}
				for (int i = 1; i <= (n-(n+1) / 2)-1; i++)
				{	
					Console.WriteLine ((new string ('-', i)) + "*"+(new string ('-',(n-(2*i+2)))) + "*"+(new string ('-', i)));
				}
				if (n > 1) 
				{
					Console.WriteLine ((new string ('-', ((n + 1) / 2 - 1))) + "*" + (new string ('-', ((n + 1) / 2 - 1))));
				}

			} 		
		}
	}
}
