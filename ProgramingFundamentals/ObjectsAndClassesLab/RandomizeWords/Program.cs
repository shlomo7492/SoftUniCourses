using System;
using System.Linq;
using System.Collections.Generic;

namespace RandomizeWords
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[]text =Console.ReadLine().Split(' ');
			Random randomize = new Random ();
			for (int posOne= 0; posOne < text.Length;posOne++)
			{ 
				int posTwo = randomize.Next (text.Length);
				string tempText = text[posOne];
				text [posOne] = text [posTwo];
				text [posTwo] = tempText;
			}
			Console.WriteLine (string.Join ("\r\n", text));

		}
	}
}
