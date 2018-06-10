using System;

namespace SunGlasses
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			string stars = new string ('*', 2 * n);
			string spaces = new string(' ',n);
			string slashes = new string ('/', 2*(n-1));
			string veritcals = new string ('|', n);
			Console.WriteLine(stars+spaces+stars);
			if (n % 2 != 0) 
			{
				for (int i = 1; i <= (n - 3)/2; i++) 
				{
					Console.WriteLine ("*" + slashes + "*" + spaces + "*" + slashes + "*");

				}	
				Console.WriteLine ("*" + slashes + "*" + veritcals + "*" + slashes + "*");
				for (int i = 1; i <= (n - 3)/2; i++) 
				{
					Console.WriteLine ("*" + slashes + "*" + spaces + "*" + slashes + "*");

				}	
			}
			else
			{
				for (int i = 1; i <= (n - 3)/2; i++) 
				{
					Console.WriteLine ("*" + slashes + "*" + spaces + "*" + slashes + "*");

				}	
				Console.WriteLine ("*" + slashes + "*" + veritcals + "*" + slashes + "*");
				for (int i = 1; i <= (n - 2)/2; i++) 
				{
					Console.WriteLine ("*" + slashes + "*" + spaces + "*" + slashes + "*");

				}	
			}
			Console.WriteLine(stars+spaces+stars);
		}
	}
}
