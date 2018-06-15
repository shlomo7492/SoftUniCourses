using System;

namespace ReverseString
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string inputString = Console.ReadLine ();
			string outputStr = "";
			for (int i = (inputString.Length - 1); i >= 0; i--) 
			{
				outputStr += inputString [i];
			}
			Console.WriteLine (outputStr);
		}
	}
}
