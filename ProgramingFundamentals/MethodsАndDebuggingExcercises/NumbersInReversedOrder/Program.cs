using System;

namespace NumbersInReversedOrder
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string number = Console.ReadLine ();
			PrintDecimalNumberReversedOrder (number);
		}
		static void PrintDecimalNumberReversedOrder(string number)
		{
			for (int i = number.Length - 1; i >= 0; i--)
			{
				Console.Write (number [i]);
			}
		}
	}
}
