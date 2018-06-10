using System;

namespace TransportPrice
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			float distance = float.Parse (Console.ReadLine ());
			string dayNight = Console.ReadLine ();
			float price = 0;
			switch (dayNight) 
			{
			case "day":
				{
					if (distance < 20) 
					{
						price = (float)(0.7 + (distance * 0.79));
					} 
					else if (distance < 100) 
					{
						price = (float)(distance * 0.09);

					}
					else 
					{
						price = (float)(distance * 0.06);
					}	
				}
				break;
			case "night":
				{
					if (distance < 20) 
					{
						price = (float)(0.7 + (distance * 0.9));
					} 
					else if (distance < 100) 
					{
						price = (float)(distance * 0.09);

					}
					else 
					{
						price = (float)(distance * 0.06);
					}	
					
				}
				break;
			default:
				break;
			}
			Console.WriteLine (price);
		}
	}
}
