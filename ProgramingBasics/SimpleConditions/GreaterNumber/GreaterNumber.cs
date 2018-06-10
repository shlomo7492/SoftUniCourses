using System;

namespace GreaterNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.WriteLine ("Enter two integers:");
			var numOne = int.Parse (Console.ReadLine ());
			var numTwo= int.Parse (Console.ReadLine ());
			if (numOne >= numTwo) 
			{
				Console.WriteLine ("Greater Number: {0}",numOne);
			} 
			else 
			{
				Console.WriteLine ("Greater Number: {0}",numTwo);
			}

		}
	}
}
