using System;
using System.Globalization;
using System.Linq;

namespace AdvertisementMessage
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] phrases = new string[]{"Excellent product.", "Such a great product.", 
						"I always use that product.","Best product of its category.", 
						"Exceptional product.", "I can’t live without this product."};
			string[] events = new string[]{"Now I feel good.", "I have succeeded with this product.", 
					"Makes miracles. I am happy of the results!","I cannot believe but now I feel awesome.", 
					"Try it yourself, I am very satisfied.", "I feel great!"};
			string[] authors = new string[]{"Diana", "Petya", "Stella","Elena", "Katya", "Iva","Annie","Eva"};
			string[] cities = new string[]{"Burgas", "Sofia", "Plovdiv","Varna", "Ruse"};
		
			PrintAddvert (int.Parse (Console.ReadLine ()),
						phrases, events, authors, cities);
		}
		static void PrintAddvert(int number,string[] phrases,
								string[] events, string[] authors, string[] cities)
		{
			for (int i = 1; i <= number; i++) 
			{
				Random randomize = new Random ();
				string phrase = phrases [randomize.Next (phrases.Length)];
				string evenT = events [randomize.Next (events.Length)];
				string author = authors [randomize.Next (authors.Length)];
				string city = cities [randomize.Next (cities.Length)];
				Console.WriteLine ($"{phrase} {evenT} {author} - {city}");
			}
		}
	}
}
