using System;

namespace StupidPasswordGenerator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int l = int.Parse (Console.ReadLine ());
			for (int i = 1; i <= n; i++) 
			{
				for (int j = 1; j <= n; j++)
				{
					for (int k = 97; k <= (97 + l - 1); k++) 
					{
						char first = (char)k;
						for (int m = 97; m <= (97 + l - 1); m++) 
						{
							char second = (char)m;
							for (int o = 1; o <= n; o++) 
							{
								if ((o > i) && (o > j)) 
								{
									Console.Write ("{0}{1}{2}{3}{4} ",i,j,first,second,o);
								}
							}
						}
					}
				}
			}
		
		}
	}
}
