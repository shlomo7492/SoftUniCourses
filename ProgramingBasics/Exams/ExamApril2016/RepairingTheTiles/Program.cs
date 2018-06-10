using System;

namespace RepairingTheTiles
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double n = double.Parse (Console.ReadLine ());
			double w = double.Parse (Console.ReadLine ());
			double l = double.Parse (Console.ReadLine ());
			double m = double.Parse (Console.ReadLine ());
			double o = double.Parse (Console.ReadLine ());
			double tiles = ((n * n) - (m * o)) / (w * l);
			Console.WriteLine (tiles);
			Console.WriteLine (tiles * 0.2);
 		}
	}
}
