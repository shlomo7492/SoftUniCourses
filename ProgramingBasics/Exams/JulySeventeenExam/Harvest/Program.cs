using System;

namespace Harvest
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int totalArea = int.Parse (Console.ReadLine ());
			double fruitfullness = double.Parse (Console.ReadLine ());
			int wineExpected = int.Parse (Console.ReadLine ());
			int workers = int.Parse (Console.ReadLine ());

			if ((((fruitfullness * totalArea) * 0.4) / 2.5) < wineExpected) 
			{
				Console.WriteLine ("It will be a tough winter! More {0:f0} liters wine needed.", (int)(wineExpected - (((fruitfullness * totalArea) * 0.4) / 2.5)));
			} 
			else if ((((fruitfullness * totalArea) * 0.4) / 2.5) >= wineExpected) 
			{
				Console.WriteLine ("Good harvest this year! Total wine: {0:f0} liters.", (int)(((fruitfullness * totalArea) * 0.4) / 2.5));

				Console.WriteLine ("{0:f0} liters left -> {1:f0} liters per person.", Math.Ceiling((((fruitfullness * totalArea) * 0.4) / 2.5) - wineExpected), Math.Ceiling((((((fruitfullness * totalArea) * 0.4) / 2.5) - wineExpected) / workers)));
				//}
			}
		}
	}
}
