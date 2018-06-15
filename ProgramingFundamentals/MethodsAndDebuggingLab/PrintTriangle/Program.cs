using System;

namespace PrintTriangle
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int num = int.Parse (Console.ReadLine ());
			PrintTopPart (num);
			PrintLine (num);
			PrintBottomPart (num);
		}
		static void PrintLine(int num)
		{
			for (int i = 1; i <= num; i++) 
			{
				Console.Write (i + " ");
			}
			Console.WriteLine ();
		}
		static void PrintTopPart (int num)
		{
			for (int i = 1; i < num; i++) 
			{
				PrintLine (i);
			}
		}
		static void PrintBottomPart (int num)
		{
			for (int i = num-1; i >= 1; i--) 
			{
				PrintLine (i);
			}
		}

	}
}
