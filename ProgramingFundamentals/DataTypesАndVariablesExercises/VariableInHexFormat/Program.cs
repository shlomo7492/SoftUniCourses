using System;

namespace VariableInHexFormat
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string hexNum = Console.ReadLine ();
			Console.WriteLine (Convert.ToInt32 (hexNum, 16));	
		}
	}
}
