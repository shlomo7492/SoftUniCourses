using System;

namespace VegetableMarket
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double priceVegies = double.Parse (Console.ReadLine ());
			double priceFruits = double.Parse (Console.ReadLine ());
			int vegies = int.Parse (Console.ReadLine ());
			int fruits = int.Parse (Console.ReadLine ());

			Console.WriteLine (((priceVegies*vegies)+(priceFruits*fruits))/1.94);
 		}
	}
}
