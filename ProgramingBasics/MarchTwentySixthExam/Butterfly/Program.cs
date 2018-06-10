using System;

namespace Butterfly
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			Console.WriteLine ((new String ('*', n - 2)) + "\\ /" + (new String ('*', n - 2)));
			for (int i = 1; i <= ((2 * (n - 2) + 1)-3)/4; i++) 
			{
				Console.WriteLine ((new String ('-', n - 2)) + "\\ /" + (new String ('-', n - 2)));
				Console.WriteLine ((new String ('*', n - 2)) + "\\ /" + (new String ('*', n - 2)));
			}
			Console.WriteLine ((new String (' ', n - 1)) + "@");				
			Console.WriteLine ((new String ('*', n - 2)) + "/ \\" + (new String ('*', n - 2)));
			for (int i = 1; i <= ((2 * (n - 2) + 1)-3)/4; i++) 
			{
				Console.WriteLine ((new String ('-', n - 2)) + "/ \\" + (new String ('-', n - 2)));
				Console.WriteLine ((new String ('*', n - 2)) + "/ \\" + (new String ('*', n - 2)));
			}
		}
	}
}
