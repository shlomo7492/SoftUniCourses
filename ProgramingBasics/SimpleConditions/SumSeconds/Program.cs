using System;

namespace SumSeconds
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var timingOne = int.Parse (Console.ReadLine ());
			var timingTwo = int.Parse (Console.ReadLine ());
			var timingThree = int.Parse (Console.ReadLine ());
			Console.WriteLine ("{0}:{1:00}",((timingOne+timingTwo+timingThree)/60),((timingOne+timingTwo+timingThree)%60) );
		}
	}
}
