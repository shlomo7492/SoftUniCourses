using System;

namespace MaxMethod
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int firstNum = int.Parse (Console.ReadLine ());
			int secondNum = int.Parse (Console.ReadLine ());
			int thirdNum = int.Parse (Console.ReadLine ());
			if (GetMax (firstNum, secondNum) >= thirdNum) 
			{
				Console.WriteLine (GetMax (firstNum, secondNum));
			}
			else 
			{
				Console.WriteLine (thirdNum);
			}
		}
		public static int GetMax(int first,int second)
		{
			if (first >= second)
			{
				return first;
			} 
			else
			{
				return second;
			}
		}
	}
}
