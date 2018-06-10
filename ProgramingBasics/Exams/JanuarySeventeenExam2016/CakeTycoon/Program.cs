using System;

namespace CakeTycoon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong cakesWanted = ulong.Parse (Console.ReadLine ());
			decimal flourNeeded = decimal.Parse (Console.ReadLine ());
			uint flourAvailiable = uint.Parse (Console.ReadLine ());
			uint truffles = uint.Parse (Console.ReadLine ());
			uint priceTruff = uint.Parse (Console.ReadLine ());

			if ((flourAvailiable / flourNeeded) < cakesWanted) 
			{
				Console.WriteLine ("Can make only {0} cakes, need {1:f2} kg more flour", (int)(flourAvailiable / flourNeeded), ((decimal)cakesWanted * flourNeeded) - (decimal)flourAvailiable);
			}
			else
			{
				Console.WriteLine ("All products available, price of a cake: {0:f2}", (((decimal)truffles * (decimal)priceTruff) / (decimal)cakesWanted)*1.25m);
			}
		}
	}
}
