using System;

namespace BaiIvanAdventures
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int day = int.Parse (Console.ReadLine ());
			decimal money = decimal.Parse (Console.ReadLine ());
			decimal desiredAlcochol = decimal.Parse (Console.ReadLine ());
			decimal amountBought = 0;

			switch (day) 
			{
			case 0:
				amountBought = money / 25m;
				break;
			case 1:
				amountBought = money / 21m;
				break;
			case 2:
				amountBought = money / 14m;
				break;
			case 3:
				amountBought = money / 17m;
				break;
			case 4:
				amountBought = money / 45m;
				break;
			case 5:
				amountBought = money / 59m;
				break;
			case 6:
				amountBought = money / 42m;
				break;
			default:
				break;
			}
			string status = "";
			if (amountBought >= 1.5m) 
			{
				status = "very drunk";
			} 
			else if (amountBought >= 1) 
			{
				status = "drunk";
			} 
			else 
			{
				status = "sober";				
			}
			if (amountBought > desiredAlcochol) 
			{
				Console.WriteLine ("Bai Ivan is {0} and very happy and he shared {1:f2} l. of alcohol with his friends", status, amountBought - desiredAlcochol);
			}
			else if (amountBought == desiredAlcochol) 
			{
				Console.WriteLine ("Bai Ivan is {0} and happy. He is as drunk as he wanted", status);
			} 
			else
			{
				Console.WriteLine ("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol", status, desiredAlcochol - amountBought);
			}
		}
	}
}
