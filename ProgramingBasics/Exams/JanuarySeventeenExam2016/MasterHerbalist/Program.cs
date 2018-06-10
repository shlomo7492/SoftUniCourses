using System;

namespace MasterHerbalist
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int dailyExpences = int.Parse (Console.ReadLine ());
			int dayCount = 0;
			string path;
			int hours;
			int price;
			int moneyEarned = 0;
			for (int i = 1; i <= 100; i++) 
			{
				string inputLine = Console.ReadLine ();
				if (inputLine == "Season Over") 
				{
					break;
				}
				string[] impArr = inputLine.Split (' ');
				dayCount++;
				hours = int.Parse (impArr [0]);
				path = impArr [1];
				price = int.Parse (impArr[2]);
				while (hours > 0) 
				{

					for (int j = 0; j < path.Length; j++) 
					{
						if (hours != 0) 
						{
							if (path [j] == 'H')
							{
								moneyEarned += price;
							}
							hours--;
						}
					}
				}
			}
			if (moneyEarned >= (dayCount * dailyExpences)) 
			{
				Console.WriteLine ("Times are good. Extra money per day: {0:f2}.",((decimal)moneyEarned/(decimal)dayCount)-(decimal)dailyExpences);
			} 
			else 
			{
				Console.WriteLine ("We are in the red. Money needed: {0}.",(dailyExpences*dayCount)-moneyEarned);
			}
		}
	}
}
