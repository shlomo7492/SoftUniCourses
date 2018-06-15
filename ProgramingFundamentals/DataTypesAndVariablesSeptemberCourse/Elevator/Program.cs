using System;

namespace Elevator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int people = int.Parse (Console.ReadLine ());
			int elevCapcity = int.Parse (Console.ReadLine ());
			Console.WriteLine (Math.Ceiling ((double)people/elevCapcity));
		}
	}
}
