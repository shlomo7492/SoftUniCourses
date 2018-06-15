using System;

namespace VowelOrDigit
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number;
			string testStr = Console.ReadLine ();
			bool test = int.TryParse (testStr,out number);
			if ((test == true) && ((number >= 0) && (number <= 9))) 
			{
				Console.WriteLine ("digit");
			}
			else
			{
				switch (testStr.ToLower())
				{
				case "a":
				case "e":
				case "i":
				case "o":
				case "u":
				case "y":
					Console.WriteLine ("vowel");
					break;
				default:
					Console.WriteLine ("other");
					break;
					
				}
			}
		}
	}
}
