using System;

namespace BeerStock
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long amountOfBeer = long.Parse (Console.ReadLine ());
			long allBeers = 0;
			for (int i = 0; i <= 100; i++) 
			{
				string inputLine = Console.ReadLine ();
				if (inputLine == "Exam Over") 
				{
					break;
				}
				string[] inputArr = inputLine.Split (' ');
				switch (inputArr [1]) 
				{
					case "beers":
						allBeers = allBeers + long.Parse(inputArr [0]);
						break;
					case "sixpacks":
						allBeers = allBeers + (long.Parse(inputArr [0])*6);
						break;
					case "cases":
						allBeers = allBeers + (long.Parse(inputArr [0])*24);
						break;
					default:
						break;
				}
			}
			allBeers = allBeers - (long)(allBeers / 100);
			if (allBeers < amountOfBeer) 
			{
				Console.WriteLine ("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", (amountOfBeer - allBeers) / 24, ((amountOfBeer - allBeers) % 24) / 6, ((amountOfBeer - allBeers) % 24) % 6);
			}
			else
			{
				Console.WriteLine ("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", (allBeers - amountOfBeer) / 24, ((allBeers - amountOfBeer) % 24) / 6, ((allBeers - amountOfBeer) % 24) % 6);
			}
		}
	}
}
