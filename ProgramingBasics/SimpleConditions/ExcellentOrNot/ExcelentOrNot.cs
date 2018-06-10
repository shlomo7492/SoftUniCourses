using System;

namespace ExcellentOrNot
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var grade = double.Parse (Console.ReadLine ());

			if (grade >= 5.5) 
			{
				Console.WriteLine ("Excellent!");
			}
			else
			{
				Console.WriteLine ("Not excellent.");
			}
		}
	}
}
