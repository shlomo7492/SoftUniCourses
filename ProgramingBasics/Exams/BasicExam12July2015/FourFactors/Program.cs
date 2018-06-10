using System;

namespace FourFactors
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			uint fieldGoals = uint.Parse (Console.ReadLine ()); //FG
			uint fieldsGoalsAttempts = uint.Parse (Console.ReadLine ()); //FGA
			uint threePointFieldGoals = uint.Parse (Console.ReadLine ()); //3P
			uint turnovers = uint.Parse (Console.ReadLine ()); //TOV
			uint offensveRebounds = uint.Parse (Console.ReadLine ()); //ORB
			uint oppDefensiveRebounds = uint.Parse (Console.ReadLine ()); // Opp DRB
			uint freeThrows = uint.Parse (Console.ReadLine ());//FT
			uint freeThrowAttempts = uint.Parse (Console.ReadLine ());//FTA

			Console.WriteLine ("eFG% {0:f3}",(fieldGoals + 0.5 * threePointFieldGoals) / fieldsGoalsAttempts);
			Console.WriteLine ("TOV% {0:f3}", turnovers/ (fieldsGoalsAttempts + 0.44 * freeThrowAttempts + turnovers));
			Console.WriteLine ("ORB% {0:f3}",(double)offensveRebounds / (offensveRebounds + oppDefensiveRebounds));
			Console.WriteLine ("FT% {0:f3}", (double)freeThrows / fieldsGoalsAttempts);
				
		}
	}
}
