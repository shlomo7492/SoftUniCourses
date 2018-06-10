using System;

namespace Diamond
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			Console.WriteLine ((new String('.',n))+(new String('*',3*n))+(new String('.',n)));
			for (int i = 1; i <= n-1; i++) 
			{
				Console.WriteLine ((new String('.',n-i))+"*"+(new String('.',(3*n)+((i-1)*2)))+"*"+(new String('.',n-i)));
			}
			Console.WriteLine (new String('*',5*n));
			for (int i = 1; i < 2 * n + 1; i++) 
			{
				Console.WriteLine ((new String('.',i))+"*"+(new String('.',(5*n-2) - (i*2)))+"*"+(new String('.',i)));

			}
			Console.WriteLine ((new String('.',2 * n + 1))+(new String('*',n-2))+(new String('.',2 * n + 1)));

		}
	}
}
