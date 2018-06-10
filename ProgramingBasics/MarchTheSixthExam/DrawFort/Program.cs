using System;

namespace DrawFort
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			Console.Write (	"/"+(new string ('^',n/2))+"\\");
			if ((n%2)!=0) 
			{
				Console.Write (new string ('_', n - 3));
			}
			else
			{
				Console.Write (new string ('_', n - 4));
			}
			Console.WriteLine (	"/"+(new string ('^',n/2))+"\\");

			for (int i = 1; i <= (n - 3); i++) 
			{
				Console.WriteLine("|"+(new string(' ',((2*n)-2)))+"|");
			}

			Console.Write ("|"+(new string(' ',(n/2+1))));
			if ((n%2)!=0) 
			{
				Console.Write (new string ('_', n - 3));
			}
			else
			{
				Console.Write (new string ('_', n - 4));
			}
			Console.WriteLine ((new string(' ',(n/2+1)))+"|");

			Console.Write (	"\\"+(new string ('_',n/2))+"/");
			if ((n%2)!=0) 
			{
				Console.Write (new string (' ', n - 3));
			}
			else
			{
				Console.Write (new string (' ', n - 4));
			}
			Console.Write (	"\\"+(new string ('_',n/2))+"/");


		}
	}
}
