using System;

namespace Operations
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int nOne = int.Parse (Console.ReadLine ());
			int nTwo = int.Parse (Console.ReadLine ());
			string action = Console.ReadLine ();
			string evenOdd = "odd";

			switch (action) {
			case "+":
				{
					if ((nOne + nTwo) % 2 == 0) {
						evenOdd = "even";
					}
					Console.WriteLine ("{0} + {1} = {2} - {3}", nOne, nTwo, nOne + nTwo, evenOdd);
				}
				break;
			case "-":
				{
					if ((nOne - nTwo) % 2 == 0) {
						evenOdd = "even";
					}
					Console.WriteLine ("{0} - {1} = {2} - {3}", nOne, nTwo, nOne - nTwo, evenOdd);
				}
				break;
			case "*":
				{
					if ((nOne * nTwo) % 2 == 0) {
						evenOdd = "even";
					}
					Console.WriteLine ("{0} * {1} = {2} - {3}", nOne, nTwo, nOne * nTwo, evenOdd);
				}
				break;
			case "/":
				{
					if (nTwo == 0) {
						Console.WriteLine ("Cannot divide {0} by zero", nOne);
					} else {
						Console.WriteLine ("{0} / {1} = {2:f2}", nOne, nTwo, (float)nOne / nTwo);
					}
				}
				break;
			case "%":
				{
					if (nTwo == 0) {
						Console.WriteLine ("Cannot divide {0} by zero", nOne);
					} else {
						Console.WriteLine ("{0} % {1} = {2}", nOne, nTwo, nOne % nTwo);
					}
				}
				break;
			default:
				break;
			}

		}
	}
}
