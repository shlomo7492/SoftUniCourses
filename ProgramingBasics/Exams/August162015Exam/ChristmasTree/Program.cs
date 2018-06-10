using System;

namespace ChristmasTree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());

			for (int i = 1; i <= n; i += 2) 
			{
				Console.WriteLine((new string('\'',((2*n+1)-i)/2))+(new string('^',i))+(new string('\'',((2*n+1)-i)/2)));
			}
			for (int i = 3; i <= n+2; i += 2) 
			{
				Console.WriteLine((new string('\'',((2*n+1)-i)/2))+(new string('^',i))+(new string('\'',((2*n+1)-i)/2)));
			}
			for (int i = 1; i <= n-(n/2); i ++) 
			{
				Console.WriteLine((new string('\'',n-1))+"| |"+(new string('\'',n-1)));
			}
			Console.WriteLine (new string('-',2*n+1));
		}
	}
}
