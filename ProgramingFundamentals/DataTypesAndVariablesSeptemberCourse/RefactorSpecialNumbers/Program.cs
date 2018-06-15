using System;

namespace RefactorSpecialNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int endNum = int.Parse(Console.ReadLine());
			for (int ch = 1; ch <= endNum; ch++)
			{				
				int sum = (ch % 10) + (ch / 10);

				Console.WriteLine("{0} -> {1}",ch,((sum == 5) || (sum == 7) || (sum == 11)));
			}		
		}
	}
}
