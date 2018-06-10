using System;

namespace NumbersInRange
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool test = false;
			int n;
			string str = "";
			while (test == false) 
			{
				Console.Write ("Еnter a number in the range [1...100]: ");
				str = Console.ReadLine ();
				test = int.TryParse (str, out n);
				if ((test == true) && ((n < 1) || (n > 100)))
				{
					Console.WriteLine ("Invalid number!");
					test = false;
				}
				else
				{
					Console.WriteLine ("The number is: {0}",n);
				}
			}
		}
	}
}
