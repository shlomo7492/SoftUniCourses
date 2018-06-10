using System;

namespace PlaidTowel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int size = int.Parse (Console.ReadLine ());
			char backSymb = char.Parse (Console.ReadLine ());
			char rombus = char.Parse (Console.ReadLine ());
			Console.WriteLine ((new string (backSymb, size)) + rombus + (new string (backSymb, size+(size-1))) + rombus + (new string (backSymb, size)));
			TowelPrint (backSymb, rombus, size);
			Console.WriteLine ((new string (backSymb, size)) + rombus + (new string (backSymb, size+(size-1))) + rombus + (new string (backSymb, size)));
			TowelPrint (backSymb, rombus, size);
			Console.WriteLine ((new string (backSymb, size)) + rombus + (new string (backSymb, size+(size-1))) + rombus + (new string (backSymb, size)));
		}
		public static void TowelPrint(char back,char rombus, int n)
		{
			for (int j = 1; j <= n-1; j++)
			{
				Console.WriteLine ((new string (back, n - j)) + rombus + (new string (back, j + (j - 1))) + rombus + (new string (back, (n + (n-1)) - (j * 2))) + rombus + (new string (back, j + (j - 1))) + rombus + (new string (back, n - j)));
			}
			Console.WriteLine (rombus + (new string (back, n+(n-1))) + rombus + (new string (back, n+(n-1))) + rombus);
			for (int j = n-1; j >= 1; j--)
			{
				Console.WriteLine ((new string (back, n - j)) + rombus + (new string (back, j + (j - 1))) + rombus + (new string (back, (n + (n-1)) - (j * 2))) + rombus + (new string (back, j + (j - 1))) + rombus + (new string (back, n - j)));
			}
		}
	}
}
