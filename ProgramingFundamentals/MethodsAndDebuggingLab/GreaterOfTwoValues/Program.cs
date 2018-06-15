using System;

namespace GreaterOfTwoValues
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string typeOfInput = Console.ReadLine ();
			string firstValue = Console.ReadLine ();
			string secondValue = Console.ReadLine ();
			switch (typeOfInput) 
			{
			case "int":
				{
					Console.WriteLine(GetMax (int.Parse(firstValue), int.Parse(secondValue)));
				}
				break;
			case "char":
				{
					Console.WriteLine (GetMax (char.Parse (firstValue), char.Parse (secondValue)));
				}
				break;
			case "string":
				{
					Console.WriteLine(GetMax (firstValue, secondValue));
				}
				break;
				
			default:
				break;
			}
		}


		public static int GetMax (int first,int second)
		{
			if (first >= second) 
			{
				return first;
			}
			else 
			{
				return second;
			}
		}
		public static char GetMax (char first,char second)
		{
			if (first >= second)
			{
				return first;
			}
			else 
			{
				return second;
			}
		}
		public static string GetMax (string first,string second)
		{
			if (first.CompareTo(second) >= 0) 
			{
				return first;
			}
			else 
			{
				return second;
			}
		}
	}
}
