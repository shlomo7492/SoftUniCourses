using System;

namespace SignOfIntegerNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number = int.Parse (Console.ReadLine ());
			PrintSign (number);
		}
		public static void PrintSign (int number)
		{
			if (number > 0) 
			{
				Console.WriteLine ("The number {0} is positive.",number);
			} 
			else if (number < 0) 
			{
				Console.WriteLine ("The number {0} is negative.",number);
			} 
			else 
			{
				Console.WriteLine ("The number {0} is zero.",number);
			}
		}
	}
}
