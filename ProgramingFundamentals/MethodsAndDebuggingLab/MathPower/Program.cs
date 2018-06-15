using System;

namespace MathPower
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double inputValue = double.Parse (Console.ReadLine ());
			int power = int.Parse (Console.ReadLine ());
			Console.WriteLine (RiseToPower(inputValue,power));
		}
		public static double RiseToPower(double baseValue,int power)
		{
			double result = 1;
			for (int i = 1; i <= power; i++) 
			{
				result *= baseValue;
			}
			return result;
		}
	}
}
