﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAverage
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			double[] numbers = new double[n];
			for (int i = 0; i < n; i++) 
			{
				numbers [i] = double.Parse (Console.ReadLine ());
			}
			Console.WriteLine($"Sum = {numbers.Sum()}");
			Console.WriteLine($"Min = {numbers.Min()}");
			Console.WriteLine($"Max = {numbers.Max()}");
			Console.WriteLine($"Average = {numbers.Average()}");
		}
	}
}
