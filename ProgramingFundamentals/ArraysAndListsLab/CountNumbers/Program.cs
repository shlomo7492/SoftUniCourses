using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CountNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbers = Console.ReadLine();
			PrintCountedElementsOfList (GetList (numbers));
		}
		static IList<int> GetList(string numbers)
		{
			char[] empty = new char[] { ' ' };
			var inputList = numbers.Split(empty ,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			return inputList;
		}
		static void PrintCountedElementsOfList (IList<int> numList)
		{
			int index = 0;
			numList = numList.OrderBy(d => d).ToList();
			while (index < numList.Count)
			{
				int countNum = index;
				int num = numList[index];
				while ((countNum< numList.Count)&&(numList[countNum]==num))
				{
					countNum += 1;
				}
				if (countNum != 0) 
				{
					Console.WriteLine (num + " -> " + (countNum-index));
				}
				index = countNum;
			}
		}
	}
}
