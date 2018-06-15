using System;

namespace GeometryCalculator
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string figure = Console.ReadLine ();
			GetAction (figure);
		}
		static double TriangleArea (double side, double height)
		{
			return (side * height) / 2;
		}
		static double SquareArea (double side)
		{
			return Math.Pow (side, 2);
		}
		static double RectangleArea (double sideA, double sideB)
		{
			return sideA * sideB;
		}
		static double CircleArea (double radius)
		{
			return Math.PI * radius * radius;
		}
		static void GetAction(string figure)
		{
			switch (figure) 
			{
			case "triangle":
				{
					double side = double.Parse (Console.ReadLine ());
					double height = double.Parse (Console.ReadLine ());
					Console.WriteLine ("{0:f2}",TriangleArea (side, height));
				}
				break;
			case "square":
				{
					double side = double.Parse (Console.ReadLine ());
					Console.WriteLine ("{0:f2}",SquareArea (side));
				}
				break;
			case "rectangle":
				{
					double sideA = double.Parse (Console.ReadLine ());
					double sideB = double.Parse (Console.ReadLine ());
					Console.WriteLine ("{0:f2}",RectangleArea (sideA, sideB));
				}
				break;
			case "circle":
				{
					double radius = double.Parse (Console.ReadLine ());
					Console.WriteLine ("{0:f2}",CircleArea (radius));
				}
				break;
			default:
				break;
			}
		}
	}
}
