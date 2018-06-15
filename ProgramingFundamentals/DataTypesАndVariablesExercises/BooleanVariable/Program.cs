using System;

namespace BooleanVariable
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			bool boolVar = Convert.ToBoolean (Console.ReadLine ());
			if (boolVar)
			{
				Console.WriteLine ("Yes");
			} 
			else
			{
				Console.WriteLine ("No");
			}
		}
	}
}
