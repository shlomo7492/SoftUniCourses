using System;

namespace DateTameExersize
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string dateInput = Console.ReadLine ();
			char[] separator = {'-'};
			string[] components = dateInput.Split (separator);
			int year = int.Parse(components[2]);
			int month =int.Parse(components[1]);
			int day = int.Parse(components[0]);
			DateTime date1 = new DateTime(year, month, day);
			DateTime thousandDaysLater = date1.AddDays(1000);
			Console.WriteLine(thousandDaysLater.ToString("dd-MM-yyyy"));
		}
	}
}
