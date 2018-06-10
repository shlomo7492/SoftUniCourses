using System;

namespace StripedTowel
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int width = int.Parse (Console.ReadLine ());
			int height = (int)Math.Floor (width * 1.5);
			int heightcount = 0;
			//Console.WriteLine (height);
			while (heightcount < height) {
				for (int i = 1; i <= 3; i++)
				{
					string line = "";
					string startSymbol = "";
					if (i % 2 == 0) 
					{
						startSymbol = startSymbol + "..";
					} 
					else if (i % 3 == 0) 
					{
						startSymbol = startSymbol + ".";
					} 
					else 
					{
						startSymbol = startSymbol + "#";
					}
					line = line + startSymbol;

					while (line.Length < width) {
						if (line.Length > 1) {
							if (line [line.Length - 1] == '#') {
								line = line + ".";
							} else if ((line [line.Length - 1] == '.') && (line [line.Length - 2] == '.')) {
								line = line + "#";
							} else if ((line [line.Length - 1] == '.') && (line [line.Length - 2] == '#')) {
								line = line + ".";
							}
						} else { 
							if (line == "#") {
								line = line + ".";
							} else if (line == ".") {
								line = line + "#";
							}
						}
					}
					Console.WriteLine (line);
					heightcount++;
					if (heightcount == height) 
					{
						break;
					}
				}
			}
		}
	}
}
