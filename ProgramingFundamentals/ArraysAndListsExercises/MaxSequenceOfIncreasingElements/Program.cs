using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MaxSequenceOfIncreasingElements
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] intArr = Console.ReadLine ().Split (' ').Select (int.Parse).ToArray ();
			PrintMethod (intArr);
		}
		static int[] GetLongestLeftmostSeq (int[] arr,int start,int length)
		{
			return arr.Skip (start).Take (length).ToArray ();
		}
		static void PrintMethod(int[] arr)
		{
			int bestStart = 0;
			int bestLength = 1;
			int start = 0;
			int len = 1;

			while (start < arr.Length) 
			{
				for (int i = start + 1; i < arr.Length; i++) 
				{
					if (arr [i] > arr [i - 1]) 
					{ 
						len++;
					} else 
					{
						break;
					}
				}
				if (len > bestLength) 
				{
					bestStart = start;
					bestLength = len;
					start = start + len;
					len = 1;
				}
				else if(len==bestLength)
				{
					start = start + len;
					len = 1;
				}
				else if (len<bestLength)
				{
					start = start + len;
					len = 1;
				}
			}
			Console.WriteLine (string.Join (" ", GetLongestLeftmostSeq (arr, bestStart, bestLength)));
		}

	}
}
