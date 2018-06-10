using System;

namespace SumDigits
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string theNum = Console.ReadLine ();
			int sum = 0;
			for (int i = 0; i < theNum.Length; i++)
			{
				sum= sum + int.Parse (theNum [i].ToString ());
			}
			Console.WriteLine (sum);
		}
	}
}																																																																																																																																																																												