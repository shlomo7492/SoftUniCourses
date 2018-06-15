using System;

namespace FibonacciNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int index = int.Parse (Console.ReadLine ());
			Console.WriteLine (GetNthFibonachiNumber (index));
		}
		static ulong GetNthFibonachiNumber (int index)
		{
				ulong fibNum;
				if (index == 0)
				{
					fibNum = 1ul;
				} 
				else if (index == 1)
				{
					fibNum = 1ul;
				}
				else
				{
				fibNum = GetNthFibonachiNumber (index - 1) + GetNthFibonachiNumber (index - 2);
				}
				return fibNum;
		}
	}
}
