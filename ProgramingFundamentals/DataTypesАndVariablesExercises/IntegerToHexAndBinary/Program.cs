using System;

namespace IntegerToHexAndBinary
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int number = int.Parse (Console.ReadLine ());
			Console.WriteLine ((Convert.ToString(number,16)).ToUpper());
			Console.WriteLine (Convert.ToString(number,2));
		}
	}
}
