using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbers = Console.ReadLine();
			PrintList (GetSquares (GetList (numbers)));
		}
		static IList<int> GetList(string numbers)
		{
			char[] empty = new char[] { ' ' };
			var inputList = numbers.Split(empty ,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
			return inputList;
		}
		static IList<int> GetSquares(IList<int> numList)
		{
			var newList=new List<int>();
			foreach(int num in numList)
			{
				if (Math.Sqrt(num)== (int)Math.Sqrt(num))
				{
					newList.Add(num);
				}
			}
			return newList.OrderByDescending(d => d).ToList();
		}
		static void PrintList (IList<int> numList)
		{
			Console.WriteLine (string.Join (" ", numList));
		}

	}
}
