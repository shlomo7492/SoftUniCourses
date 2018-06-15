using System;
using System.Collections.Generic;

namespace IndexOfLetters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var alfabetIndexed = new Dictionary<char,int> ();
			for (int i = 0; i < 26; i++) 
			{
				alfabetIndexed [(char)(97 + i)] = i;
			}
			string word = Console.ReadLine ().ToLower();
			for (int i = 0; i < word.Length; i++)
			{
				foreach (var element in alfabetIndexed) 
				{
					if (word[i]== element.Key)
					{
						Console.WriteLine ($"{element.Key} -> {element.Value}");
					}
				}
			}
		}
	}
}
