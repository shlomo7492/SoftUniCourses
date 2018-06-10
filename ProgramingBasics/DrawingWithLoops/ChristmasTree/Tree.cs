using System;

namespace ChristmasTree
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			string firstSpaces = new string (' ', n + 1);
			Console.WriteLine (firstSpaces + "|");
			for (int i = 1; i <= n; i++) 
			{
				Console.WriteLine((new string(' ',n-i))+(new string('*',i))+" | "+ (new string('*',i)));
			}
		}
	}
}
