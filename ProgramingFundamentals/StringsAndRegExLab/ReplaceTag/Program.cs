using System;
using System.Text.RegularExpressions;

namespace ReplaceTag
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string htmlCode = Console.ReadLine ();

			while (htmlCode != "end")
			{
				string patern = @"<a.*?href.*?=""(\S.*?)"">(.*?)<\/a>";
				string replacement = @"[URL href=""$1""]$2[\/URL]";
				Regex regex = new Regex (patern);
				string replaced = regex.Replace (htmlCode, replacement);
				Console.WriteLine (replaced);
				htmlCode = Console.ReadLine ();
			}
		}
	}
}
