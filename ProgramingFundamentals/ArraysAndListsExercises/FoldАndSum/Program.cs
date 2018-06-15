using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldАndSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			IList<int> numbers = Console.ReadLine ().Split(' ').Select(int.Parse).ToList();
			PrintSum (GetFoldAndSum (numbers));
		}
		static IList<int> GetFoldAndSum (IList<int> master)
		{
			int k = master.Count/4;
			IList<int> firstList =new List<int>();
			for (int i = k-1; i >= 0; i--) 
			{
				firstList.Add (master [i]);
			}
			for (int i = ((4 * k) -1); i >=3*k ; i--) 
			{
				firstList.Add (master [i]);
			}
			for (int i = 0; i <2*k; i++) 
			{
				firstList [i] += master [i+k];
			}
			return firstList;
		}
		static void PrintSum (IList<int> master)
		{
			Console.WriteLine (string.Join (" ",master));
		}
	}
}
