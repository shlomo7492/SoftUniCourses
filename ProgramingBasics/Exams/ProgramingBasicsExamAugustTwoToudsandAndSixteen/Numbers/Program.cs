using System;
using System.Text;

namespace Numbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbersInput = Console.ReadLine ();
			int[] digits = new int[3];
			for (int i = 0; i < numbersInput.Length; i++) 
			{
				digits [i] = int.Parse ("" + numbersInput [i]);
			}
			int digit = int.Parse (numbersInput);
			int n = digits [0] + digits [1];
			int m = digits [0] + digits [2];
			for (int i = 1; i <= n; i++)
			{
				for (int j = 1; j <= m; j++) 
				{
					if (digit % 5 == 0) 
					{
						digit = digit - digits [0];
				
					} 
					else if (digit % 3 == 0)
					{
						digit = digit - digits [1];
					} 
					else
					{
						digit = digit + digits [2];
					}
					if (j < m) 
					{
						Console.Write ("{0} ", digit);
					} 
					else 
					{
						Console.WriteLine ("{0}", digit);
					}
				}

			}
		}
	}
}
