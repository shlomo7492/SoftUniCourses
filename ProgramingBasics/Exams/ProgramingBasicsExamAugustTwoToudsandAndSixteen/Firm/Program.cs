using System;

namespace Firm
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double projectHours = double.Parse (Console.ReadLine ());
			double firmDays = double.Parse (Console.ReadLine ());
			double overTimers = double.Parse (Console.ReadLine ());

			double workHours = (((double)firmDays / 100d)*90) * 8 +overTimers*2*firmDays;
			if (workHours >= projectHours)
			{
				Console.WriteLine ("Yes!{0} hours left.", Math.Floor (workHours) - projectHours);
			} 
			else 
			{
				Console.WriteLine ("Not enough time!{0} hours needed.", projectHours - Math.Floor (workHours));
			}
		}
	}
}
