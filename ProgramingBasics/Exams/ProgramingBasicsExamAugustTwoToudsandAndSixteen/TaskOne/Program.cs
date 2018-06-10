using System;

namespace DailyProfit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int workDays = int.Parse (Console.ReadLine ());
			decimal dayWadge = decimal.Parse (Console.ReadLine ());
			decimal dolarToLeva = decimal.Parse (Console.ReadLine ());

			decimal monthlySal = workDays * dayWadge;
			decimal anualSal = monthlySal * 12m +monthlySal*2.5m;
			anualSal = (anualSal * 0.75m)*dolarToLeva;

			Console.WriteLine("{0:f2}",anualSal/365m);

		}
	}
}
