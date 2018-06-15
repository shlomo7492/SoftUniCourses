using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string firstInput = Console.ReadLine ();
			string secondInput = Console.ReadLine ();
			IList<char> firstCharSet = GetListFromString (firstInput);
			IList<char> secondCharSet = GetListFromString (secondInput);
			PrintOrderedCharSets (firstCharSet,secondCharSet);
		}
		static IList<char> GetListFromString(string input)
		{
			IList<char> charSeq =new List<char>();
			for (int i = 0; i < input.Length; i++) 
			{
				if (input [i] != ' ') 
				{
					charSeq.Add (input [i]);
				}
			}
			return charSeq;
		}
		static int GetShorterCharSetLength(IList<char> first,IList<char> second)
		{
			int k = 0;
			if (first.Count >= second.Count) 
			{
				k = second.Count;
			}
			else
			{
				k = first.Count;
			}
			return k;
		}
		static void PrintOrderedCharSets(IList<char> first,IList<char> second)
		{
			int lenght = GetShorterCharSetLength (first, second);
			bool isFirst=false;
			int equal = 0;
			for (int i = 0; i < lenght; i++) 
			{
				if (first [i] < second [i])
				{
					isFirst = true;
					break;
				} 
				else if (first [i] == second [i]) 
				{
					equal++;
				}
				else
				{
					break;
				}
			}
			if (isFirst) 
			{
				Console.WriteLine (string.Join ("", first));
				Console.WriteLine (string.Join ("", second));
			}
			else if (equal == lenght)
			{
				if (first.Count < second.Count) 
				{
					Console.WriteLine (string.Join ("", first));
					Console.WriteLine (string.Join ("", second));
				} 
				else if(first.Count > second.Count) 
				{
					Console.WriteLine (string.Join ("", second));
					Console.WriteLine (string.Join ("", first));
				}
				else
				{
					Console.WriteLine (string.Join ("", first));
					Console.WriteLine (string.Join ("", second));
				}

			}
			else
			{
				Console.WriteLine (string.Join ("", second));
				Console.WriteLine (string.Join ("", first));
			}
		}
	}
}
