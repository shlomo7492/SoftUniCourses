using System;

namespace TimeMachine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			decimal moneyInherit = decimal.Parse (Console.ReadLine ());
			int yearToEnd = int.Parse (Console.ReadLine ());
			decimal moneyNeeded = 0m;
			int age = 18;
			for (int i = 1800; i <= yearToEnd; i++) 
			{
				if (i % 2 == 0)
				{
					moneyNeeded += 12000m;
				} 
				else 
				{
					moneyNeeded += 12000m + (decimal)(50 * age);
				}
				age++;
			}
			if (moneyInherit >= moneyNeeded) 
			{
				Console.WriteLine ("Yes! He will live a carefree life and will have {0:f2} dollars left.",moneyInherit-moneyNeeded);
			} 
			else 
			{
				Console.WriteLine ("„He will need {0:f2} dollars to survive.",moneyNeeded-moneyInherit);
			}
		}
	}
}
