using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveОfEratosthenes
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int n = int.Parse (Console.ReadLine ());
			PrintPrime (n);
		}
		static void PrintPrime(int n)
		{
			bool[] primeArray = new bool[n + 1];
			primeArray [0] = primeArray [1] = false;
			for (int i = 2; i <= n; i++) 
			{
				primeArray [i] = true;
			}

			Console.WriteLine (string.Join(" ",GetPrimeList (primeArray, n)));
		}
		static IList<int> GetPrimeList (bool[] primeArray,int n)
		{
			var intList=new List<int>();
			for (int i = 2; i <= n; i++) 
			{
				if (primeArray [i]) 
				{
					intList.Add(i);
					int increment = i;
					while ((increment*i) <= n) 
					{
						primeArray [increment * i] = false;
						increment++;
					}
				}
			}
			return intList;
		}
	}

}
