using System;

namespace RectangleProperties
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double width = double.Parse (Console.ReadLine ());
			double height = double.Parse (Console.ReadLine ());

			Console.WriteLine ("{0:###0.##############}",((2 * width) + (2 * height)));
			Console.WriteLine ("{0:###0.##############}",width*height);
			Console.WriteLine ("{0:###0.##############}",Math.Sqrt(Math.Pow(width,2) + Math.Pow(height,2)));
		}
	}
}
