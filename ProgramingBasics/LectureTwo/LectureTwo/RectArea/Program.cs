using System;

namespace RectArea

{
	class Area
	{
		public static void Main()
		{
			var xOne = double.Parse (Console.ReadLine ());
			var yOne = double.Parse (Console.ReadLine ());
			var xTwo = double.Parse (Console.ReadLine ());
			var yTwo = double.Parse (Console.ReadLine ());
			var area = (Math.Abs(xOne-xTwo))*(Math.Abs(yOne-yTwo));
			var perimeter = ((Math.Abs(xOne-xTwo))+(Math.Abs(yOne-yTwo)))*2;
			Console.WriteLine ("Area = " + area);
			Console.WriteLine ("Perimeter = " + perimeter);



		}

	}

}