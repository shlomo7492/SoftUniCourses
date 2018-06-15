using System;

namespace ReversedChars
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string reversed = "";
			for (int i = 1; i <= 3; i++)
			{
				char input = char.Parse (Console.ReadLine ());
				reversed = input + reversed;
			}
			Console.WriteLine (reversed);
		}
	}
}
