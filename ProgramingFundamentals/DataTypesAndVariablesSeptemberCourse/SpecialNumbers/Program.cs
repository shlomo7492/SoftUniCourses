using System;

namespace SpecialNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			for (int i = 1; i <= n; i++)
			{
				string number = i.ToString();
				int sum = 0;
				for (int j = 0; j < number.Length; j++) 
				{
					sum += int.Parse (number [j] + "");
				}
				if ((sum == 5) || (sum == 7) || (sum == 11)) 
				{
					Console.WriteLine ("{0} -> True", number);
				}
				else
				{
					Console.WriteLine ("{0} -> False", number);
				}
    
			}
		}
	}
}
