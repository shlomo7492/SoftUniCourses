using System;

namespace FastPrimeChecker
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int range = int.Parse(Console.ReadLine());
			for (int currentNum = 2; currentNum <= range; currentNum++)
			{
				bool primeCheck = true;
				for (int divider = 2; divider <= Math.Sqrt(currentNum); divider++)
				{
					if (currentNum % divider == 0)
					{
						primeCheck = false;
						break;
					}
				}
				Console.WriteLine($"{currentNum} -> {primeCheck}");
			}
		}
	}
}
