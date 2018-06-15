using System;
using System.Linq;
using System.Collections.Generic;

namespace CountRealNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double[] numbers = Console.ReadLine ().Split (' ').Select (x => double.Parse (x)).ToArray ();
			SortedDictionary<double,int> counts=new SortedDictionary<double, int>();
			foreach (var num in numbers) 
			{
				if (counts.ContainsKey (num)) 
				{
					counts [num]++;
				} 
				else 
				{
					counts [num] = 1;
				}
			}
			foreach (var pair in counts) 
			{
				Console.WriteLine ($"{pair.Key} -> {pair.Value}");
			}
		}
	}
}
