using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int[] baseArray = Console.ReadLine ().Split (' ').Select(int.Parse).ToArray();
			PrintRotateAndSum (baseArray);
		}
		static int[] GetRotatedArr(int[] baseArray)
		{
			int tempValue;
			tempValue = baseArray [baseArray.Length - 1];
			for (int i=baseArray.Length-1;i>=1;i--)
			{
				baseArray [i] = baseArray [i - 1];
			}
			baseArray [0] = tempValue;
			return baseArray;
		}

		static void PrintRotateAndSum(int[] baseArray)
		{
			int[] sum = new int[baseArray.Length];

			int numberOfRepeats = int.Parse (Console.ReadLine ());
			for (int i = 1; i <= numberOfRepeats; i++) 
			{
				GetRotatedArr (baseArray);

				for (int j = 0; j < baseArray.Length; j++)
				{
					sum [j] =sum[j] + baseArray [j];
				}

			}
			Console.WriteLine (string.Join (" ", sum));
		}
	}
}
