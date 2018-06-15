using System;

namespace DrawAFilledSquare
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = int.Parse (Console.ReadLine ());
			PrintHorizontalBorder (num);
			PrintLines (num);
			PrintHorizontalBorder (num);
		}
		static void PrintHorizontalBorder(int num)
		{
			Console.WriteLine (new string ('-', 2 * num));
		}
		static void PrintInsidePart(int num)
		{
			for (int i = 1; i <= num - 1; i++) 
			{
				Console.Write ("\\/");
			}
		}
		static void PrintLines (int num)
		{
			for (int i = 1; i <= num - 2; i++) 
			{
				Console.Write ("-");
				PrintInsidePart (num);
				Console.WriteLine ("-");
			}
		}
	}
}
