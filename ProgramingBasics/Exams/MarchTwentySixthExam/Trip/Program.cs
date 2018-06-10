using System;

namespace Trip
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float budget = float.Parse (Console.ReadLine ());
			string season = Console.ReadLine ();

			switch (season) 
			{
			case "summer":
				{
					if (budget <= 100) 
					{
						Console.WriteLine ("Somewhere in Bulgaria");
						Console.WriteLine ("Camp - {0:f2}",(budget*0.3f));
					}
					else if (budget <= 1000)
					{
						Console.WriteLine ("Somewhere in Balkans");
						Console.WriteLine ("Camp - {0:f2}",(budget*0.4f));
					} 
					else 
					{
						Console.WriteLine ("Somewhere in Europe");
						Console.WriteLine ("Hotel - {0:f2}",(budget*0.9f));
					}
				}
				break;
			case "winter":
				{
					if (budget <= 100) 
					{
						Console.WriteLine ("Somewhere in Bulgaria");
						Console.WriteLine ("Hotel - {0:f2}",(budget*0.7f));
					}
					else if (budget <= 1000)
					{
						Console.WriteLine ("Somewhere in Balkans");
						Console.WriteLine ("Hotel - {0:f2}",(budget*0.8f));
					} 
					else 
					{
						Console.WriteLine ("Somewhere in Europe");
						Console.WriteLine ("Hotel - {0:f2}",(budget*0.9f));
					}
				}
				break;
			default:
				break;
			}
		}
	}
}
