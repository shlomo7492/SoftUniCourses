	using System;

	namespace Summertime
	{
		class MainClass
		{
			public static void Main (string[] args)
			{
				int n = int.Parse (Console.ReadLine ());
				Console.WriteLine((new string(' ',(2*n - (n+1))/2))+(new string('*',n+1)));
			for (int i = 1; i <= n - (n / 2); i++) 
				{
					Console.WriteLine((new string(' ',(2*n - (n+1))/2))+"*"+(new string(' ',n-1))+"*");
				}
				for (int i = 1; i <= ((n-2) / 2); i++) 
				{
					Console.WriteLine ((new string(' ',((2*n - (n+1))/2)-(i)))+"*"+(new string(' ',(n-1)+2*i))+"*");
				}
				for (int i = 1; i <= n; i++) 
				{
					Console.WriteLine ("*"+(new string('.',(2*n)-2)+"*"));
				}
				for (int i = 1; i <= n; i++) 
				{
					Console.WriteLine ("*"+(new string('@',(2*n)-2)+"*"));
				}
				Console.WriteLine((new string('*',2*n)));
			}
		}
	}
