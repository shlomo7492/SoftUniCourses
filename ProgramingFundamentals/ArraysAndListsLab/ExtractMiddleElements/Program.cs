using System;

namespace ExtractMiddleElements
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbers = Console.ReadLine ();
			PrintTheMidleElements (GetArray (numbers));
		}
		static int[] GetArray(string inputString)
		{
			string[] stringArr = inputString.Split(' ');
			int[] intArr = new int[stringArr.Length];
			for (int i = 0; i < stringArr.Length; i++)
			{
				intArr [i] = int.Parse(stringArr [i]);
			}
			return intArr;
		}
		static void PrintTheMidleElements(int[] intArr)
		{
			Console.Write ("{ ");

			if (intArr.Length % 2 != 0) 
			{
				if (intArr.Length != 1)
				{
					for (int i = ((intArr.Length / 2) - 1); i <= ((intArr.Length / 2) + 1); i++) 
					{
						Console.Write (intArr [i] + " ");
					}
					
				}
				else
				{
					Console.Write (intArr [0]);
				}
			} 
			else 
			{
				for (int i = ((intArr.Length / 2) - 1); i <= (intArr.Length / 2); i++) 
				{
					Console.Write (intArr [i] + " ");
				}
			}
			Console.WriteLine ("}");
		}
	}
}
