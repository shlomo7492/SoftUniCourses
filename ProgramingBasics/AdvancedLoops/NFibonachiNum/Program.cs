using System;

namespace NFibonachiNum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int nFib = int.Parse (Console.ReadLine ());
			int[] fibArr = new int[nFib+1];;
			for (int i = 0; i <= nFib; i++) 
			{
				if (i == 0) 
				{
					fibArr [i] = 1;
				}
				else if (i == 1) 
				{
					fibArr [i] = 1;
				} 
				else 
				{
					fibArr [i] = fibArr [i - 1] + fibArr [i - 2];
				}
			}
			Console.WriteLine (fibArr[nFib]);
		}
	}
}
