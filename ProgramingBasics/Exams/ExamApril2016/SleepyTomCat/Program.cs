using System;

namespace SleepyTomCat
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int playMinutes = ((365 - n) * 63) + (n * 127);
			if (playMinutes > 30000) 
			{
				Console.WriteLine ("Tom will run away");
				Console.WriteLine ("{0} hours and {1} minutes more for play", (playMinutes - 30000) / 60, (playMinutes - 30000) % 60);
			}
			else 
			{
				Console.WriteLine ("Tom sleeps well");
				Console.WriteLine ("{0} hours and {1} minutes less for play", (30000 - playMinutes) / 60, (30000 - playMinutes) % 60);
			}
		}
	}
}
