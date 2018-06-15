using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElementsList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> intList = Console.ReadLine ().Split (' ').Select (int.Parse).ToList();
			PrintMethod (intList);
		}

		//Returns number of elements (length) starting from (start) position as a new int[]
		static List<int>  GetLongestLeftmostSeq (List<int> intList,int start,int length)
		{
			return intList.Skip (start).Take (length).ToList ();
		}
		static void PrintMethod(List<int> intList)
		{
			int bestStart = 0;
			int bestLength = 1;
			int start = 0;
			int len = 1;

			while (start < intList.Count) 
			{
				for (int i = start + 1; i < intList.Count; i++) 
				{
					if (intList [i] == intList [i - 1]) 
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
			Console.WriteLine (string.Join (" ", GetLongestLeftmostSeq (intList, bestStart, bestLength)));
		}

	}
}