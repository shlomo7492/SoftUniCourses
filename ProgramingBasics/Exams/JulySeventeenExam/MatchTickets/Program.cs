using System;

namespace MatchTickets
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double budget = double.Parse (Console.ReadLine ());
			string ticketType = Console.ReadLine ();
			int groupMembers = int.Parse (Console.ReadLine ());

			if (groupMembers <= 4) 
			{
				budget = budget * 0.25;
			} 
			else if (groupMembers <= 9) 
			{
				budget = budget * 0.40;

			} 
			else if (groupMembers <= 24) 
			{
				budget = budget * 0.50;
			} 
			else if (groupMembers <= 49) 
			{
				budget = budget * 0.60;
			}
			else if (groupMembers > 50)
			{
				budget = budget * 0.75;
			}
			if (ticketType == "VIP") 
			{
				if ((groupMembers * 499.99) <= budget)
				{
					Console.WriteLine ("Yes! You have {0:f2} leva left.", budget - (groupMembers * 499.99));
				} 
				else
				{
					Console.WriteLine ("Not enough money! You need {0:f2} leva.",(groupMembers * 499.99)-budget);
				}
			}
			else
			{
				if ((groupMembers * 249.99) <= budget)
				{
					Console.WriteLine ("Yes! You have {0:f2} leva left.", budget - (groupMembers * 249.99));
				} 
				else
				{
					Console.WriteLine ("Not enough money! You need {0:f2} leva.",(groupMembers * 249.99)-budget);
				}
			}
		}
	}
}
