using System;
using System.Linq;

namespace DistanceBetweenPoints
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Point myPoint = new Point (){ X = 5, Y = 3 };
			Point firstPoint = ReadPoint ();
			Point secondPoint = ReadPoint ();

			double distance = CalculateDistanceBetwenTwoPoints (firstPoint, secondPoint);

			Console.WriteLine($"{distance:f3}");


		}
		static Point ReadPoint()
		{
			int[] pointInput = Console.ReadLine ()
										.Split (' ')
										.Select (int.Parse)
										.ToArray ();
			Point point = new Point ();
			point.X = pointInput [0];
			point.Y = pointInput [1];
			return point;
		}
		static double CalculateDistanceBetwenTwoPoints(Point pointOne, Point pointTwo)
		{
			int deltaX = pointOne.X - pointTwo.X;
			int deltaY = pointOne.Y - pointTwo.Y;
			return Math.Sqrt (deltaX*deltaX + deltaY*deltaY);
		}
	}
	class Point
	{
		public int X 
		{
				get;
				set;
		}
		public int Y
		{
				get;
				set;
		}
	}
	
}
