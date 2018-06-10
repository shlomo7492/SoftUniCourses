using System;

namespace FootballStatistics
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			decimal matchEuros = decimal.Parse (Console.ReadLine ());
			string inputLine = Console.ReadLine ();
			int arsenalPoints = 0;
			int chelseaPoints = 0;
			int evertonPoints = 0;
			int liverpoolPoints = 0;
			int manCityPoints = 0;
			int manUndPoints = 0;
			int southHamptonPoints = 0;
			int tottenhamPoints = 0;
			int matchCount = 0;
			while (inputLine != "End of the league.") 
			{
				matchCount++;
				string[] stringSeparators = new string[] {" "};
				string[] splitArr = inputLine.Split (stringSeparators,StringSplitOptions.RemoveEmptyEntries);
				foreach (string value in splitArr) 
				{
					Console.WriteLine (value);
				}
				if (splitArr [1] == "1") 
				{
					switch (splitArr [0])
					{
						case "Arsenal":
							arsenalPoints += 3;
							break;
						case "Chelsea":
							chelseaPoints += 3;
							break;
						case "Everton":
							evertonPoints += 3;
							break;
						case "Liverpool":
							liverpoolPoints += 3;
							break;
						case "ManchesterCity":
							manCityPoints += 3;
							break;
						case "ManchesterUnited":
							manUndPoints += 3;
							break;
						case "Southampton":
							southHamptonPoints += 3;
							break;
						case "Tottenham":
							tottenhamPoints += 3;
							break;
						default:
							break;
					}
				} 
				else if (splitArr [1] == "2") 
				{
					switch (splitArr [2])
					{
						case "Arsenal":
							arsenalPoints += 3;
							break;
						case "Chelsea":
							chelseaPoints += 3;
							break;
						case "Everton":
							evertonPoints += 3;
							break;
						case "Liverpool":
							liverpoolPoints += 3;
							break;
						case "ManchesterCity":
							manCityPoints += 3;
							break;
						case "ManchesterUnited":
							manUndPoints += 3;
							break;
						case "Southampton":
							southHamptonPoints += 3;
							break;
						case "Tottenham":
							tottenhamPoints += 3;
							break;
						default:
							break;
					}
				} 
				else 
				{
					switch (splitArr [0])
					{
						case "Arsenal":
							arsenalPoints += 1;
							break;
						case "Chelsea":
							chelseaPoints += 1;
							break;
						case "Everton":
							evertonPoints += 1;
							break;
						case "Liverpool":
							liverpoolPoints += 1;
							break;
						case "ManchesterCity":
							manCityPoints += 1;
							break;
						case "ManchesterUnited":
							manUndPoints += 1;
							break;
						case "Southampton":
							southHamptonPoints += 1;
							break;
						case "Tottenham":
							tottenhamPoints += 1;
							break;
						default:
							break;
					}
					switch (splitArr [2])
					{
						case "Arsenal":
							arsenalPoints += 1;
							break;
						case "Chelsea":
							chelseaPoints += 1;
							break;
						case "Everton":
							evertonPoints += 1;
							break;
						case "Liverpool":
							liverpoolPoints += 1;
							break;
						case "ManchesterCity":
							manCityPoints += 1;
							break;
						case "ManchesterUnited":
							manUndPoints += 1;
							break;
						case "Southampton":
							southHamptonPoints += 1;
							break;
						case "Tottenham":
							tottenhamPoints += 1;
							break;
						default:
							break;
					}
				}
				inputLine = Console.ReadLine ();
			}
			Console.WriteLine("{0:f2}lv.",matchCount*matchEuros*1.94m);
			Console.WriteLine ("Arsenal - {0} points.", arsenalPoints);
			Console.WriteLine ("Chelsea - {0} points.", chelseaPoints);
			Console.WriteLine ("Everton - {0} points.", evertonPoints);
			Console.WriteLine ("Liverpool - {0} points.", liverpoolPoints);
			Console.WriteLine ("Manchester City - {0} points.", manCityPoints);
			Console.WriteLine ("Manchester United - {0} points.", manUndPoints);
			Console.WriteLine ("Southampton - {0} points.", southHamptonPoints);
			Console.WriteLine ("Tottenham - {0} points.", tottenhamPoints);
		}
	}
}
