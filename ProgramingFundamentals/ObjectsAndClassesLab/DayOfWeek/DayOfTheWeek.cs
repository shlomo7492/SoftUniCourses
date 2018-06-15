using System;
using System.Globalization;

namespace DayOfTheWeek
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string dateInTextFormat = Console.ReadLine ();
			DateTime date = DateTime.ParseExact (dateInTextFormat, "d-MM-yyyy", CultureInfo.InvariantCulture);
			Console.WriteLine (date.DayOfWeek);
		}
	}
}
