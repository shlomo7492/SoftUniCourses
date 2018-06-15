using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			double[] sequenceOfLetters = Console.ReadLine ().Split(' ').Select(x => double.Parse(x)).ToArray();
			Dictionary<double,int> numbersCount= new Dictionary<double,int>();
			foreach (double number in sequenceOfLetters) 
			{
				if (numbersCount.ContainsKey(number))
				{
					numbersCount [number]++;
				}
				else
				{
					numbersCount [number] = 1;
				}
			}
			var numbersCountSorted = numbersCount.OrderByDescending (element => element.Value)
				                                 .ToDictionary(element=>element.Key,element=>element.Value);
			foreach (var element in numbersCountSorted) 
			{
				Console.WriteLine ($"{element.Key}");
				break;
			}

		}
	}
}
