using System;

namespace TakeThePlanesDown
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int x = int.Parse (Console.ReadLine ());
			int y = int.Parse (Console.ReadLine ());
			int distance = int.Parse (Console.ReadLine ());
			int n = int.Parse (Console.ReadLine ());
			int[] planes = new int[2*n];
			for (int i = 0; i <= 2 * n - 1; i++) 
			{
				if ((i+1)%2 != 0) 
				{
					planes[i] = int.Parse (Console.ReadLine ());
				} 
				else 
				{
					planes[i] = int.Parse (Console.ReadLine ());
				}
			}
			for (int i = 0; i <= 2 * n - 1; i+=2) 
			{
				if ((Math.Abs (planes [i] - x) <= distance) && (Math.Abs (planes [i + 1] - y) <= distance)) 
				{
					Console.WriteLine ("You destroyed a plane at [{0},{1}]", planes [i], planes [i + 1]);
				}
			} 
		}
	}
}
