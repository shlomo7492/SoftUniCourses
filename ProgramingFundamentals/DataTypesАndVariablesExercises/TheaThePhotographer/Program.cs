using System;

namespace TheaThePhotographer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long picTaken = long.Parse (Console.ReadLine ());
			long filterTime = long.Parse (Console.ReadLine ());
			long filterFactor = long.Parse (Console.ReadLine ());
			long uploadTime = long.Parse (Console.ReadLine ());

			long timeInSeconds = picTaken * filterTime;
			Console.WriteLine ("*"+timeInSeconds);
			picTaken = (long)Math.Ceiling(picTaken * ((double)filterFactor / 100));
			Console.WriteLine ("**"+picTaken);

			timeInSeconds += picTaken * uploadTime;
			Console.WriteLine ("**"+timeInSeconds);
			Console.WriteLine ("minutes:seconds"+timeInSeconds/60+":"+timeInSeconds%60);

			Console.WriteLine ("{0:#0}:{1:00}:{2:00}:{3:00}",
				timeInSeconds/(24*3600),
				(timeInSeconds%(24*3600))/3600,
				((timeInSeconds%(24*3600))%3600)/60,
				((timeInSeconds%(24*3600))%3600)%60);
		}
	}
}
