using System;
using System.IO;
using System.Collections.Generic;

namespace OddLines
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] allText = File.ReadAllLines ("Input.txt");
			List<string> oddLines = new List<string> ();
			for (int i = 0; i < allText.Length; i++)
			{
				if (i % 2 != 0)
				{
					oddLines.Add (allText[i]);
				}
			}				

			File.WriteAllLines ("output.txt", oddLines);

		}
	}
}
