using System;

namespace CenterPoint
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double xOne = double.Parse (Console.ReadLine ());
			double yOne = double.Parse (Console.ReadLine ());
			double xTwo = double.Parse (Console.ReadLine ());
			double yTwo = double.Parse (Console.ReadLine ());
			PrintClosestPoint (xOne, yOne, xTwo, yTwo);
		}
		static double DistanceFromCenter (double xCoordinate,double yCoordinate)
		{
			return Math.Sqrt (Math.Pow(xCoordinate,2)+Math.Pow(yCoordinate,2));
		}
		static void PrintClosestPoint (double xOne, double yOne,double xTwo, double yTwo)
		{
			if (DistanceFromCenter (xOne, yOne) <= DistanceFromCenter (xTwo, yTwo)) 
			{
				Console.WriteLine ("({0}, {1})", xOne, yOne);
			}
			else 
			{
				Console.WriteLine ("({0}, {1})", xTwo, yTwo);
			}
		}
	}
}
