using System;
using System.Globalization;
using System.Linq;

namespace CountWorkDays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			DateTime startDate = DateTime.ParseExact (Console.ReadLine ()
				, "dd-M-yyyy", CultureInfo.InvariantCulture);
			DateTime endDate = DateTime.ParseExact (Console.ReadLine ()
				, "dd-M-yyyy", CultureInfo.InvariantCulture);
			string[] stateHolidays = GetStateHolidays();
			int workingDaysCount = 0;
			for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
			{
				if ((date.DayOfWeek != DayOfWeek.Saturday &&
				    date.DayOfWeek != DayOfWeek.Sunday) &&
					(stateHolidays.Contains (date.ToString ("dd.MM")) == false)) 
				{ 	
					workingDaysCount++;
				}
			}
			Console.WriteLine (workingDaysCount);
		}
		static string[] GetStateHolidays ()
		{
			string[] stateHolidays = new string[11]{"01.01",
													"03.03",
													"01.05", 
													"06.05",
													"24.05",
													"06.09",
													"22.09",
													"01.11",
													"24.12", 
													"25.12",
													"26.12"};
			return stateHolidays;
		}

	}
}
