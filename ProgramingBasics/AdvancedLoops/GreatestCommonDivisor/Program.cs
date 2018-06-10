using System;

namespace GreatestCommonDivisor
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int first = int.Parse (Console.ReadLine ());
			int second = int.Parse (Console.ReadLine ());
			while (first != second) 
			{ 
				if (first > second) 
				{
					first = first - second;
				} 
				else
				{
					second = second - first;
				}
			}
			Console.WriteLine (first);

		}
	}
}
