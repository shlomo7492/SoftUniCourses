using System;

namespace TextFilter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			char[] separator = new char[]{ ' ', ',' };
			string[] banList = Console.ReadLine ().Split (separator,StringSplitOptions.RemoveEmptyEntries);
			string text = Console.ReadLine ();
			for (int i = 0; i < banList.Length; i++) 
			{
				text = text.Replace (banList [i], new string('*',banList[i].Length));
			}
			Console.WriteLine (text);
		}
	}
}
