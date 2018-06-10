using System;

namespace FireFighters
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int fireFighters = int.Parse (Console.ReadLine ());
			string inputLine = Console.ReadLine ();
			char[] letters = new char[]{'K', 'A', 'S'};
			int[] saved = new int[3]{0,0,0};
			while (inputLine != "rain") 
			{
				int saves = fireFighters;
				for (int j = 0; j <= letters.Length-1; j++) 
				{
					for (int i = 0; i <= inputLine.Length - 1; i++) 
					{
						if (saves == 0) 
						{
							break;
						}
						if (inputLine [i] == letters [j]) 
						{
							saves--;
							saved [j]++;
						}
							
					}
				}
				inputLine = Console.ReadLine ();
			}
			Console.WriteLine ("Kids: {0}",saved[0]);
			Console.WriteLine ("Adults: {0}",saved[1]);
			Console.WriteLine ("Seniors: {0}",saved[2]);
		}
	}
}
