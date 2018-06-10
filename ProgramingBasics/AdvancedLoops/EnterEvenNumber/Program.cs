using System;

namespace EnterEvenNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string testStr = "";
			bool test = false;
			int number;
			while (test == false) 
			{
				Console.Write ("Enter even number: ");
				testStr = Console.ReadLine ();
				test = int.TryParse (testStr, out  number);
				if (test == true) 
				{
					if ((number % 2) == 0) 
					{
						Console.WriteLine ("Even number entered: {0}", number);
					} 
					else 
					{
						Console.WriteLine ("The number is not even.");
						test = false;
					}
				} 
				else 
				{
					Console.WriteLine ("Invalid number!");
				}
			}
		}
	}
}
