using System;

namespace ConvertSpeedUnits
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float distance = float.Parse (Console.ReadLine ());
			float hours = float.Parse (Console.ReadLine ());
			float minutes = float.Parse (Console.ReadLine ());
			float seconds = float.Parse (Console.ReadLine ());
			float timeInSeconds = (hours * 3600f) + (minutes * 60f) + seconds;
			Console.WriteLine ("{0:###0.#######}",distance/timeInSeconds);
			Console.WriteLine ("{0:###0.#######}",(distance/1000f)/(timeInSeconds/3600f));
			Console.WriteLine ("{0:###0.#######}",(distance/1609f)/(timeInSeconds/3600f));
		}
	}
}
