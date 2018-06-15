using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string numbers = Console.ReadLine();

			Console.WriteLine (string.Join (" <= ",GetSortedList (GetList(numbers))));
		}
		static IList<decimal> GetList(string numbers)
		{
			char[] empty = new char[] {' '};
			var inputList = numbers.Split(empty ,StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).ToList();
			return inputList;
		}
		static IList<decimal> GetSortedList (IList<decimal> numberList)
		{
			return numberList.OrderBy(d => d).ToList();
		}

	}
}
