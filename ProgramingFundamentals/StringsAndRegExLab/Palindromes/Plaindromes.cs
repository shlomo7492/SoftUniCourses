using System;
using System.Linq;
using System.Collections.Generic;

namespace Palindromes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Char[] delimiter = new char[]{' ',',','.','?','!'};
			string[] textSorted = Console.ReadLine ()
				.Split (delimiter, StringSplitOptions.RemoveEmptyEntries)
				.Distinct ()
				.ToArray ();
			bool palindrome = false;
			List<string> sortedPalindromes = new List<string> ();
			foreach (string word in textSorted) 
			{
				if (word.Length == 1) 
				{
					palindrome = true;
				} 
				else 
				{
					for (int i = 0; i < word.Length / 2; i++) 
					{
						if (word [i] != word [(word.Length - 1) - i])
						{
							palindrome = false;
							break;
						}
						else 
						{
							palindrome = true;
						}

					}
				}
				if (palindrome) 
				{
					sortedPalindromes.Add (word);
					palindrome = false;
				}
			}
			sortedPalindromes = sortedPalindromes.OrderBy (x => x).ToList ();
			Console.WriteLine(string.Join(", ",sortedPalindromes));
		}
	}
}
