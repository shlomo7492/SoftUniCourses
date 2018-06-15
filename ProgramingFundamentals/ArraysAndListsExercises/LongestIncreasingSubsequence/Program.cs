using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestIncreasingSubsequence
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<int> intList = Console.ReadLine ().Split (' ').Select (int.Parse).ToList();
			PrintMethod (intList);
		}

		//Returns number of elements (length) starting from (start) position as a new int[]
		static List<int>  GetLongestLeftmostSeq (List<int> intList,int start)
		{
			//string subSeq = intList[start];
			List<int> newList= new List<int>();
			for (int i = start; i < intList.Count; i++) 
			{
				for (int k = i + 1; k < intList.Count; k++) 
				{
					if (intList [i] < intList [k]) 
					{
						newList.Add (intList [k]);
					}
				}
			}
			return intList.Skip (start).ToList ();
		}
		static void PrintMethod(List<int> intList)
		{
			int bestStart = 0;
			int bestLength = 1;
			int start = 0;
			int len = 1;

			for (int i = 0; i <= intList.Count; i++) 
			{
				start = i;
				for (int k = i + 1; k < intList.Count; k++) 
				{
					if (intList [i] < intList [k]) 
					{
						len++;
					}
				}
				//1 2 5 3 5 2 4 1
				if (len > bestLength) 
				{
					bestLength = len;
					bestStart = start;
				}
			}

			/*while (start < arr.Length) 
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
			}*/
				Console.WriteLine (string.Join (" ", GetLongestLeftmostSeq (intList, bestStart)));
		}


	}
}