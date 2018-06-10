using System;

namespace SudokuResults
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string time = "";
			int gameCount = 0;
			int seconds = 0;
			while (time != "Quit") 
			{
				time = Console.ReadLine ();
				if (time != "Quit") 
				{
					string[] minSec = time.Split (':');
					seconds += (int.Parse (minSec [1])+(int.Parse (minSec[0])*60));
					gameCount++;
				}
			}
			decimal average = (decimal)seconds / gameCount;
			if (gameCount > 0) 
			{
				if (average < 720)
				{
					Console.WriteLine ("Gold Star");
				} 
				else if (average <= 1440) 
				{
					Console.WriteLine ("Silver Star");
				} 
				else 
				{
					Console.WriteLine ("Bronze Star");
				}
			}
			Console.WriteLine ("Games - {0} \\ Average seconds - {1}", gameCount, Math.Ceiling (average));
		}
	}
}
