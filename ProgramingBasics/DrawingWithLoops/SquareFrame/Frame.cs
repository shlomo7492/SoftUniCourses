using System;

namespace SquareFrame
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			string innerDash=" ";
			for (int i = 1; i <= (n - 2); i++) 
			{
				innerDash = innerDash + "- ";
			}
			Console.WriteLine ("+" + innerDash + "+");
			for (int i = 1; i <= (n - 2); i++) 
			{
				Console.WriteLine ("|" + innerDash + "|");
			}
			Console.WriteLine ("+" + innerDash + "+");
		}
	}
}
