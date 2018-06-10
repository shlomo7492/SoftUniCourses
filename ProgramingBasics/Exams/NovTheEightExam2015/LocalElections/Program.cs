using System;

namespace LocalElections
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int candidates = int.Parse (Console.ReadLine ());
			int voting = int.Parse (Console.ReadLine ());
			string symbol = Console.ReadLine ();
			Vote (candidates, voting, symbol.ToLower());
		}
		public static void Vote(int lines,int choice,string symbol)
		{
			for (int i = 1; i <= lines; i++) 
			{
				Console.WriteLine (new string ('.',13));
				Console.WriteLine ("...+-----+...");
				if (choice == i)
				{
					if (symbol == "x")
					{
						Console.WriteLine ("...|.\\./.|...");
						Console.WriteLine ("{0:00}.|..X..|...",i);
						Console.WriteLine ("...|./.\\.|...");
					} 
					else if (symbol == "v") 
					{
						Console.WriteLine ("...|\\.../|...");
						Console.WriteLine ("{0:00}.|.\\./.|...",i);
						Console.WriteLine ("...|..V..|...");
					}
				} 
				else 
				{
					Console.WriteLine ("...|.....|...");
					Console.WriteLine ("{0:00}.|.....|...",i);
					Console.WriteLine ("...|.....|...");
				}
				Console.WriteLine ("...+-----+...");
			}
			Console.WriteLine (new string ('.',13));

		}
	}
}
