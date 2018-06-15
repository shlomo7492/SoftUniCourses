using System;
namespace LastKNumbersSums
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int numElements = int.Parse (Console.ReadLine ());
			int elementsToSum = int.Parse (Console.ReadLine ());
			PrintSequance(GetSequence(numElements,elementsToSum));

		}
		static ulong[] GetSequence(int numElements,int elementsToSum)
		{
			ulong[] seqArr = new ulong[numElements];
			seqArr [0] = 1;
			for (int i = 1; i < numElements; i++) 
			{
				if (elementsToSum >= i) 
				{
					for (int j = i - 1; j >= 0; j--) 
					{
						seqArr [i] += seqArr [j];
					}
				} 
				else 
				{
					for (int j = i - 1; j >= i-elementsToSum; j--) 
					{
						seqArr [i] += seqArr [j];
					}
				}
			}
			return seqArr;
		}
		static void PrintSequance (ulong[] seqArr)
		{
			string printSequance = ""+seqArr[0];
			for (int i = 1; i < seqArr.Length; i++) 
			{
				printSequance += " " + seqArr [i];
			}
			Console.WriteLine (printSequance);
		}

	}
}
