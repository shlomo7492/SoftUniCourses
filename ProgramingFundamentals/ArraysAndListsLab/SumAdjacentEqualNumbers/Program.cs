using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbers = Console.ReadLine ();
			PrintSumOfAdjacentListElements (SumTwoAdjacent (GetList (numbers)));
		}
		static IList <double> GetList(string numbers)
		{
			char[] empty = new char[] { ' ' };
			var inputList = numbers.Split(empty ,StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToList();
			return inputList;
		}
		static IList<double> SumTwoAdjacent (IList<double> numList)
		{
			for (int i = 0; i < numList.Count; i++) 
			{
				if ((i < numList.Count - 1) && (numList [i] == numList [i + 1])) {
					numList [i] += numList [i + 1];
					numList.RemoveAt (i + 1);
					return SumTwoAdjacent (numList);
				}
			}
			return numList;
		}
		static void PrintSumOfAdjacentListElements(IList<double> numList)
		{
			Console.WriteLine (string.Join (" ", numList));
		}
	}

}
