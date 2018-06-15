﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestThreeNumbers
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			List<double> numbers = Console.ReadLine ().Split (' ')
													.Select (x => double.Parse (x))
													.OrderByDescending (x => x)
													.Take (3)
													.ToList();
			Console.WriteLine (string.Join(" ",numbers));
		}
	}
}
