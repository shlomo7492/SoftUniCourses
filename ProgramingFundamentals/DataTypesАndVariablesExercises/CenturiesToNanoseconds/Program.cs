using System;

namespace CenturiesToNanoseconds
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int centures = int.Parse (Console.ReadLine ());
			int years = centures * 100;
			long days=(long)(years * 365.2422);
			long hours = days * 24;
			long minutes = hours * 60;
			decimal seconds = minutes * 60m;
			decimal milliSeconds = seconds * 1000m;
			decimal microSeconds = milliSeconds * 1000m;
			decimal nanoSeconds = microSeconds * 1000m;
			Console.WriteLine ("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centures, years, days, hours, minutes, seconds, milliSeconds, microSeconds, nanoSeconds);
		}
	}
}
