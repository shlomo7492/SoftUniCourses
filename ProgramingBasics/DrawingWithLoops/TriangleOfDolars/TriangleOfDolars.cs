using System;

namespace TriangleOfDolars
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			Console.WriteLine ("$");
			for (int i = 1; i < n; i++) 
			{
				for (int j = 1; j <= i; j++)
				{
					Console.Write ("$ ");
				}
				Console.WriteLine ("$");
			}
		}
	}
}
