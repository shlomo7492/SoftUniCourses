using System;
using System.Linq;

namespace ClosestTwoPoints
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//Point myPoint = new Point (){ X = 5, Y = 3 };
			Point[] points = ReadPoints ();

			Point[] closesPoints = FindClosesTwoPoints (points);
			double distance = CalculateDistanceBetwenTwoPoints (closesPoints[0], closesPoints[1]);

			Console.WriteLine($"{distance:f3}");
			PrintPoint (closesPoints [0]);
			PrintPoint (closesPoints [1]);


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
		static Point[] ReadPoints()
		{
			int numberOfPoints = int.Parse (Console.ReadLine ());
			Point[] points = new Point[numberOfPoints];
			for (int i = 0; i < numberOfPoints; i++)
			{
				points [i] = ReadPoint();	
			}
			return points;
		}
		static Point[] FindClosesTwoPoints(Point[] points)
		{
			double minimalDistance = double.MaxValue;
			Point[] closestTwoPoints = null;
			for (int firstPoint = 0; firstPoint < points.Length; firstPoint++) 
			{
				for (int secondPoint = firstPoint + 1; secondPoint < points.Length; secondPoint++) 
				{
					double distance = CalculateDistanceBetwenTwoPoints (points [firstPoint], points [secondPoint]);
					if (distance < minimalDistance) 
					{
						minimalDistance = distance;
						closestTwoPoints = new Point[]{ points [firstPoint], points [secondPoint] };
					}
				}
			}
			return closestTwoPoints;
		}

		static void PrintPoint(Point point)
		{
			Console.WriteLine ("({0}, {1})",point.X,point.Y);
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
