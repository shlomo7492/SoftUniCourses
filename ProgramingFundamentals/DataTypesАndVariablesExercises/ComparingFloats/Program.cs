using System;

namespace ComparingFloats
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double firstNum = double.Parse (Console.ReadLine ());
			double secondNum = double.Parse (Console.ReadLine ());
			bool check = false;
			double eps = Math.Abs (firstNum - secondNum);
			if (eps < 0.000001) 
			{
				check = true;
			}
			Console.WriteLine (check);
		}
	}
}
