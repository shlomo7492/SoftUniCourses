using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] firstArray = Console.ReadLine ().Split (' ');
			string[] secondArray = Console.ReadLine ().Split (' ');
			Console.WriteLine (GetLargestCommonEndLenght (firstArray, secondArray));
		}
		static int GetLargestCommonEndLenght(string[] first,string[] second)
		{
			int shorterLength;
			int longestLength;
			bool isFirst = false;
			int countCommon = 0;
			if (first.Length <= second.Length) 
			{
				shorterLength = first.Length;
				longestLength = second.Length;
			} 
			else
			{
				shorterLength = second.Length;
				longestLength = first.Length;
				isFirst = true;
			}
			for (int i = 0; i < shorterLength; i++) 
			{
				if (first [i] != second [i]) 
				{
					break;
				}
				else 
				{
					countCommon++;
				}
			}
			if (countCommon == 0) 
			{

				for (int i = (longestLength - 1); i >=(longestLength - shorterLength); i--) 
				{
					if (isFirst) 
					{
						if (first [i] != second [i-(longestLength-shorterLength)]) 
						{
							break;
						} 
						else 
						{
							countCommon++;
						}
					} 
					else 
					{
						if (second [i] != first [i-(longestLength-shorterLength)]) 
						{
							break;
						} 
						else 
						{
							countCommon++;
						}
					}
				}
			}
			return countCommon;
				
		}
	}

}
