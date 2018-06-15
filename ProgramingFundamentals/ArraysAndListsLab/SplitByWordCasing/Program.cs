using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string text = Console.ReadLine();
			SplitAndPrintLists (GetList (text));
		}
		static IList<string> GetList(string text)
		{
			char[] empty = new char[] { ',', ';', ':', '.', '!', '(', ')', '"', '\\', '/' ,'[' ,']' ,' ', '\u0027' };
			var inputList = text.Split(empty ,StringSplitOptions.RemoveEmptyEntries).ToList();
			return inputList;
		}
		static void PrintAListSplit (IList<string> textList,string casing)
		{
			Console.WriteLine (casing + string.Join (", ", textList));
		}

		static void SplitAndPrintLists (IList<string> textList)
		{
			List<string> upperCaseList = new List<string>();
			List<string> lowerCaseList = new List<string>();
			List<string> mixedCaseList = new List<string>();
			foreach (string element in textList) 
			{
				int upper = 0;
				int lower = 0;
				for (int i = 0; i < element.Length; i++) 
				{
					if ((element[i] >= '\u0041') && (element[i] <= '\u005A')) 
					{
						upper++;
					} else if ((element[i] >= '\u0061') && (element[i] <= '\u007A')) 
					{
						lower++;
					} 
				}
				if (element.Length == upper) 
				{
					upperCaseList.Add (element);
				} 
				else if (element.Length == lower)
				{
					lowerCaseList.Add (element);
				} 
				else
				{
					mixedCaseList.Add (element);
				}
			}
			PrintAListSplit(lowerCaseList,"Lower-case: ");
			PrintAListSplit(mixedCaseList,"Mixed-case: ");
			PrintAListSplit(upperCaseList,"Upper-case: ");
		}
				
	}
}
