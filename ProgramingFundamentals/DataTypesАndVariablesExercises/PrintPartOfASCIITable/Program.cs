using System;

namespace PrintPartOfASCIITable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int startCharIndex = int.Parse (Console.ReadLine ());
			int endCharIndex = int.Parse (Console.ReadLine ());

			for (int i = startCharIndex; i <= endCharIndex; i++) 
			{
				char printChar = (char)i;
				Console.Write (printChar + " ");
			}
		}
	}
}
