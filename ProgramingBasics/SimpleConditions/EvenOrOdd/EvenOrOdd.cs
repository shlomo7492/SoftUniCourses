using System;

namespace EvenOrOdd
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var num = int.Parse (Console.ReadLine ());
			num = num % 2;
			if (num == 0) 
			{
				Console.WriteLine ("even");
			} 
			else 
			{
				Console.WriteLine ("odd");
			}
		}
	}
}
