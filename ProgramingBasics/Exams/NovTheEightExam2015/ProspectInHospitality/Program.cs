using System;

namespace ProspectInHospitality
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			uint builders = uint.Parse (Console.ReadLine());
			uint receptionists = uint.Parse (Console.ReadLine());
			uint chambermaids = uint.Parse (Console.ReadLine());
			uint technicians = uint.Parse (Console.ReadLine());
			uint otherStaff = uint.Parse (Console.ReadLine());

			decimal nikiUsd = decimal.Parse (Console.ReadLine ());
			decimal usdCurrency = decimal.Parse (Console.ReadLine ());
			decimal mySalary = decimal.Parse (Console.ReadLine ());
			decimal budget = decimal.Parse (Console.ReadLine ());

			decimal finalPrice = (decimal)builders * 1500.04m + (decimal)receptionists * 2102.1m + (decimal)chambermaids * 1465.46m + (decimal)technicians * 2053.33m + (decimal)otherStaff * 3010.98m + mySalary + nikiUsd * usdCurrency;

			Console.WriteLine ("The amount is: {0:f2} lv.",finalPrice);
			if (finalPrice <= budget) 
			{
				Console.WriteLine("YES \\ Left: {0:f2} lv.",budget-finalPrice);
			}
			else 
			{
				Console.WriteLine("NO \\ Need more: {0:f2}  lv.",finalPrice-budget);
			}
		}
	}
}
