using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] text = Console.ReadLine ().ToLower().Split (' ');
			Dictionary <string,int> words = new Dictionary<string, int>();
			foreach (var word in text) 
			{
				if (words.ContainsKey (word)) 
				{
					words [word]++;
				} 
				else 
				{
					words [word] = 1;
				}
			}
			List <string> oddWords = new List<string> ();// words.Where (x => x.Value % 2 != 0).ToList();
			foreach(var word in words)
			{
				if (word.Value%2 != 0) 
				{
					oddWords.Add (word.Key);
				}
			}
			Console.WriteLine (string.Join (", ", oddWords));
		}
	}
}
