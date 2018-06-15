using System;

namespace CountSubstringOccurrences
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string inputText = Console.ReadLine ().ToLower ();
			string patern = Console.ReadLine ().ToLower ();
			int count = 0;
			int index = inputText.IndexOf (patern);
			while (index != -1) 
			{
				count++;
				index = inputText.IndexOf (patern, index + 1);
			}
			Console.WriteLine (count);
		}
	}
}
