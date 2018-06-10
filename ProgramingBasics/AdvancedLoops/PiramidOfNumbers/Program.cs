using System;

namespace PiramidOfNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int i=1;
			int count = 1;
			while ( count<=n)
			{
				for (int j = 1; j <= i; j++) 
				{
					Console.Write ("{0} ",count);
					count++;
					if (count > n)
					{
						break;
					}
				}
				Console.WriteLine ();
				i++;
			}
		}
	}
}
