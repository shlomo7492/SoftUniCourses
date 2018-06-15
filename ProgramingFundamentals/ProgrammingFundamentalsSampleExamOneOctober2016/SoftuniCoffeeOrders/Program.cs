using System;
using System.Globalization;

namespace SoftuniCoffeeOrders
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int numberOfEntries = int.Parse (Console.ReadLine ());
			decimal totalPrice = 0m;
			for (int i = 0; i < numberOfEntries; i++) 
			{
				decimal capsulePrice = decimal.Parse (Console.ReadLine ());
				string[] currentDate = Console.ReadLine ().Split ('/');
				DateTime date =new DateTime (int.Parse (currentDate [2]), int.Parse (currentDate [1]), int.Parse (currentDate [0]));
				int daysInMonth = DateTime.DaysInMonth (date.Year, date.Month);
				int numberOfCoffies = int.Parse (Console.ReadLine ());
				decimal price = ((daysInMonth * numberOfCoffies) * capsulePrice);
				Console.WriteLine($"The price for the coffee is: ${price:f2}");
				totalPrice += price;
			}
			Console.WriteLine ($"Total: ${totalPrice:f2}");
		}
	}
}
