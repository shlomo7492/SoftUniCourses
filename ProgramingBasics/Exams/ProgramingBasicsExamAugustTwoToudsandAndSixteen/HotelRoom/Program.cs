using System;

namespace HotelRoom
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string month = Console.ReadLine ();
			int nights = int.Parse (Console.ReadLine ());
			decimal priceStudio = 0m;
			decimal priceApartment = 0m;
			switch (month)
			{
			case "May":
			case "October":
				{
					if (nights > 14)
					{
						priceStudio = (decimal)nights * (50m * 0.7m);
						priceApartment= (decimal)nights * (65m*0.9m);
					} 
					else if (nights > 7)
					{
						priceStudio = (decimal)nights * (50m * 0.95m);
						priceApartment= (decimal)nights * 65m;

					} 
					else 
					{
						priceStudio = (decimal)nights * 50m;
						priceApartment= (decimal)nights * 65m;
					}

				}
				break;
			case "June":
			case "September":
				{
					if (nights > 14)
					{
						priceStudio = (decimal)nights * (75.20m * 0.8m);
						priceApartment= (decimal)nights * (68.70m*0.9m);
					} 
					else 
					{
						priceStudio = (decimal)nights * 75.20m;
						priceApartment= (decimal)nights * 68.70m;
					}
				}
				break;
			case "July":
			case "August":
				{
					if (nights > 14)
					{
						priceStudio = (decimal)nights * 76m;
						priceApartment= (decimal)nights * (77m*0.9m);
					} 
					else 
					{
						priceStudio = (decimal)nights * 76m;
						priceApartment= (decimal)nights * 77m;
					}
				}
				break;
			default:
				break;
			}
			Console.WriteLine ("Apartment: {0:f2} lv.", priceApartment);
			Console.WriteLine ("Studio: {0:f2} lv.", priceStudio);
		}
	}
}
