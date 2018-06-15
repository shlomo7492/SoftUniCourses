using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace WordCount
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] separator = new char[]{' ',',','-','?','!','.'};
			string[] text = File.ReadAllText ("text.txt")
						.ToLower()
						.Split(separator,StringSplitOptions.RemoveEmptyEntries);
			string[] words = File.ReadAllText ("words.txt")
						.ToLower()
						.Split(separator,StringSplitOptions.RemoveEmptyEntries);
			Dictionary<string,int> wordCount = new Dictionary<string, int> ();
			foreach (string word in words) 
			{
				foreach (string element in text) 
				{
					if (word.Equals (element))
					{
						wordCount [word]++;
					}
				}
			}
			wordCount = wordCount.OrderBy (x => x.Value).ToDictionary (x => x);
			List<string> output = new List<string>();
			foreach (KeyValuePair<string,int> element in wordCount) 
			{
				string line = element.Key + " - " + element.Value;
				output.Add (line);
			}
			File.WriteAllLines ("output.txt", output);
		}
	}
}
