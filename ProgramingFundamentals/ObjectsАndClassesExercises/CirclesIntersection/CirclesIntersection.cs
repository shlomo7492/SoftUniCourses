using System;

namespace CirclesIntersection
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Circle[] circleArr = GetCirlesToCompare ();

			double distance = CalculateDistanceBetwenTwoPoints (circleArr [0].Center, circleArr [1].Center);
			double radiusSum = (circleArr [0].Radius + circleArr [1].Radius);

			PrintIfIntersecsion (distance, radiusSum);
		}	
		static Circle[] GetCirlesToCompare()
		{
			Circle[] circleArr= new Circle[2];
			for (int i = 0; i <= 1; i++) 
			{
				string inputLine = Console.ReadLine ();
				circleArr[i] = GetCircle (inputLine);
			}
			return circleArr;
		}
		static void PrintIfIntersecsion(double distance,double radiusSum)
		{
			if (distance <= radiusSum) 
			{
				Console.WriteLine ("Yes");
			} 
			else if (distance > radiusSum) 
			{
				Console.WriteLine ("No");
			}
		}
		static Circle GetCircle(string input)
		{
			string[] inputstr = input.Split (' ');
			Circle circle = new Circle ();
			Point center = new Point ();
			center.X = int.Parse (inputstr [0]);
			center.Y = int.Parse (inputstr [1]);
			circle.Center = center;
			circle.Radius = int.Parse (inputstr [2]);
			return circle;
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
	class Circle
	{
		private Point center;

		public Point Center
		{ 
			
			get
			{
				return center;
			}
			set
			{
				center = value;
			}
		}
		public int Radius
		{ 
			get; 
			set; 
		}
		public Circle()
		{
			this.center = new Point();
		}
	}
}
