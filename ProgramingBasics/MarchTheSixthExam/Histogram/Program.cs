using System;

namespace Histogram
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int typePOne = 0;
			int typePTwo = 0;
			int typePThree = 0;
			int typePFour = 0;
			int typePFive = 0;

			for (int i = 1; i <= n; i++)
			{
				int number = int.Parse (Console.ReadLine ());
				if (number < 200) 
				{
					typePOne++;
				} 
				else if (number <= 399)
				{
					typePTwo++;
				} 
				else if (number <= 599) 
				{
					typePThree++;
				}
				else if (number <= 799)
				{
					typePFour++;
				}
				else 
				{
					typePFive++;
				}
			}
			Console.WriteLine ("{0:f2}%", ((float)typePOne / n) * 100);
			Console.WriteLine ("{0:f2}%", ((float)typePTwo / n) * 100);
			Console.WriteLine ("{0:f2}%", ((float)typePThree / n) * 100);
			Console.WriteLine ("{0:f2}%", ((float)typePFour / n) * 100);
			Console.WriteLine ("{0:f2}%", ((float)typePFive / n) * 100);

		}
	}
}
