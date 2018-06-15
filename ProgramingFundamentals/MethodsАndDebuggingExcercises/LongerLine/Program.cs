using System;

namespace LongerLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//first line coordinates
			double firstPointX = double.Parse (Console.ReadLine ());
			double firstPointY = double.Parse (Console.ReadLine ());
			double secondPointX = double.Parse (Console.ReadLine ());
			double secondPointY = double.Parse (Console.ReadLine ());

			//second line coordinates
			double thirdPointX = double.Parse (Console.ReadLine ());
			double thirdPointY = double.Parse (Console.ReadLine ());
			double fourthPointX = double.Parse (Console.ReadLine ());
			double fourthPointY = double.Parse (Console.ReadLine ());

			double firstLineLenght = GetLineLenght (firstPointX, firstPointY, secondPointX, secondPointY);
			double secondLineLenght = GetLineLenght (thirdPointX, thirdPointY, fourthPointX, fourthPointY);

			if (CompareLines (firstLineLenght, secondLineLenght) == "first") 
			{
				PrintLongerLine (firstPointX, firstPointY, secondPointX, secondPointY);
			}
			else 
			{
				PrintLongerLine (thirdPointX,thirdPointY,fourthPointX,fourthPointY);
			}

		}

		static double DistanceFromCenter (double xCoordinate,double yCoordinate)
		{
			return Math.Sqrt (Math.Pow(xCoordinate,2)+Math.Pow(yCoordinate,2));
		}

		static double GetLineLenght (double xOne, double yOne, double xTwo, double yTwo)
		{
			return Math.Sqrt (Math.Pow(Math.Abs(xOne-xTwo),2)+Math.Pow(Math.Abs(yOne-yTwo),2));
		}

		static string CompareLines (double firstLine,double secondLine)
		{
			if (firstLine >= secondLine) 
			{
				return "first";
			}
			else 
			{
				return "second";
			}
		}
		static void PrintLongerLine (double xOne, double yOne, double xTwo, double yTwo)
		{
			if (DistanceFromCenter (xOne, yOne) <= DistanceFromCenter (xTwo, yTwo)) 
			{
				Console.WriteLine ("({0}, {1})({2}, {3})", xOne, yOne, xTwo, yTwo);
			} 
			else 
			{
				Console.WriteLine ("({0}, {1})({2}, {3})", xTwo, yTwo, xOne, yOne);
			}
		}
	}
}
