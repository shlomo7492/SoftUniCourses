using System;

namespace ExcellentResult
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var grade = float.Parse (Console.ReadLine ());

			if (grade >= 5.5) 
			{
				Console.WriteLine ("Excellent!");
			}
		}
	}
}
