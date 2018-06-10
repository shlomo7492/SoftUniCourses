using System;

namespace DivisionWithoutReminder
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int[] numbers = new int[n];
			/*int[] divisors = new int[3]{0,0,0}*/;
			int divTwo = 0;
			int divThree = 0;
			int divFour = 0;

			for (int i = 0; i < n; i++) 
			{
				numbers [i] = int.Parse (Console.ReadLine ());

				if ((numbers [i] % 2) == 0) 
				{
					divTwo++;
				}

				if ((numbers [i] % 3) == 0) 
				{
					divThree++;
				}

				if ((numbers [i] % 4) == 0) 
				{
					divFour++;
				}
			}
			Console.WriteLine ("{0:#0.00}%",(((float)divTwo/(float)n)*100f));
			Console.WriteLine ("{0:#0.00}%",((float)divThree/(float)n)*100f);
			Console.WriteLine ("{0:#0.00}%",((float)divFour/(float)n)*100f);

		}
	}
}
