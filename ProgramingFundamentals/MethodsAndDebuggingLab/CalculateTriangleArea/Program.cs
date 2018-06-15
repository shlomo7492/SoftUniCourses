using System;

namespace CalculateTriangleArea
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double baseSide = double.Parse (Console.ReadLine ());
			double height = double.Parse (Console.ReadLine ());
			Console.WriteLine (GetTriangleArea (baseSide, height));
		}
		static double GetTriangleArea(double baseSide,double height)
		{
			return (baseSide * height) / 2;
		}
	}
}
