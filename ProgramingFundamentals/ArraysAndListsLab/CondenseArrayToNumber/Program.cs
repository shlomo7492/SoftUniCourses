using System;

namespace CondenseArrayToNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbers = Console.ReadLine ();	
			PrintCondensedArrayToNumber (GetArrayCondensedToNumber (GetArray (numbers)));
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
		static int[] GetCondensedArrayOneStep (int[] intArr)
		{
			int[] condensedArr=new int[intArr.Length-1];
			for (int i = 0; i < condensedArr.Length; i++) 
			{
				condensedArr [i] = intArr [i] + intArr [i + 1];
			}
			return condensedArr;
		}
		static int GetArrayCondensedToNumber (int[] intArr)
		{
			int[] condensedArr = new int[intArr.Length];
			if (intArr.Length > 1) 
			{				
				while (condensedArr.Length != 1) 
				{
					condensedArr = GetCondensedArrayOneStep (intArr);
					intArr = condensedArr;
				}
			}
			return intArr [0];
		}
		static void PrintCondensedArrayToNumber (int number)
		{
			Console.WriteLine (number);
		}
	}
}
