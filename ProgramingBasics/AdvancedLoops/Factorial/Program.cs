﻿using System;

namespace Factorial
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			int factorial = 1;
			for (int i = 1; i <= n; i++) 
			{
				factorial = factorial * i;
			}
			Console.WriteLine (factorial);	
		}
	}
}
