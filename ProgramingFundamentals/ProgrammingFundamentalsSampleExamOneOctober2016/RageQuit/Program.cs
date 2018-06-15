using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace RageQuit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string inputLine = Console.ReadLine ().ToUpper();
			Console.WriteLine( "Unique symbols used: " + CountDistinct (inputLine));

			List<string> rageStrings = new List<string> ();
			List<int> rageCounts = new List<int> ();
			GetStringCountPairs (inputLine, out rageStrings, out rageCounts);
			StringBuilder rageQuit = GetRageQuit (rageStrings, rageCounts);
			PrintRageQuit (rageQuit);
		}
		//this works well
		static int CountDistinct(string input)
		{
			string pattern = @"\D";
			MatchCollection matches = Regex.Matches(input, pattern);
			List<string> distinctMatches = new List<string>();
			for (int i = 0; i < matches.Count;i++ )
			{
				if (matches [i].Groups [0].Value != " ") 
				{
					distinctMatches.Add (matches [i].Groups [0].Value);
				}
			}
			return distinctMatches.Distinct().ToList().Count;
		}
		//this gives some errors ??? 
		static void GetStringCountPairs(string input,out List<string> strList,out List<int> intList)
		{
			MatchCollection matches = Regex.Matches(input, @"\D+");
			List<string> matchesList = new List<string>();
			for (int i = 0; i < matches.Count;i++ )
			{				
					matchesList.Add (matches [i].Groups [0].Value);
			}

			MatchCollection matchesNum = Regex.Matches(input, @"\d+");
			List<int> matchesListNum = new List<int>();
			for (int i = 0; i < matchesNum.Count;i++ )
			{				
				matchesListNum.Add (int.Parse(matchesNum [i].Groups [0].Value));
			}
			strList = matchesList;
			intList = matchesListNum;
		}
		static StringBuilder GetRageQuit (List<string> strList,List<int> intList)
		{
			StringBuilder rageQuit = new StringBuilder();
			rageQuit.Append("");
			for (int i = 0; i < intList.Count; i++) 
			{
				for (int k = 1; k <= intList [i]; k++) 
				{
					rageQuit.Append(strList [i]);
				}
			}
			return rageQuit;
		}
		static void PrintRageQuit(StringBuilder rageQuit)
		{
			Console.WriteLine (rageQuit);
		}
	}
}
