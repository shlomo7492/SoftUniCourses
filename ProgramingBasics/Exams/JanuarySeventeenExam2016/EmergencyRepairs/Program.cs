using System;

namespace EmergencyRepairs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			ulong fence = ulong.Parse (Console.ReadLine ());
			int repairKits = int.Parse (Console.ReadLine ());
			int attacks = int.Parse (Console.ReadLine ());
			for (int i = 0; i <= attacks-1; i++) 
			{
				ulong changeBit = 1ul;
				int bitAttacked = int.Parse (Console.ReadLine ());
				changeBit = changeBit << bitAttacked;
				if ((fence & changeBit) == 0) 
				{
					continue;
				}
				else 
				{
					fence = fence ^ changeBit;
				}
			}
			int isZero = 0;
			for (int j = 0; j <= 63; j++) 
			{				
				ulong changeBit = 1ul;
				changeBit = changeBit << j;
				if ((changeBit & fence) == 0) 
				{
					ulong testChange = changeBit << 1;
					if (((testChange & fence) == 0) && (j < 63))
					{
						isZero++;
					}
					else if((j < 63)&&(isZero > 0))
					{
						isZero++;
					}
					if ((fence == 0)&&(j==63)) 
					{
						isZero = 63;
					}
				}

				if ((isZero != 0) &&((j == 63) || ((changeBit & fence) != 0))) 
				{
					changeBit = changeBit >> isZero;
					Console.WriteLine (changeBit);
					if (fence == 0) 
					{
						isZero += 1;
					}
					while ((isZero != 0) && (repairKits != 0)) 
					{
						fence = changeBit ^ fence;
						changeBit = changeBit << 1;
						isZero--;
						repairKits--;

					}
					if (repairKits == 0) 
					{
						break;
					}
				}
			}
			Console.WriteLine (fence);
		}
	}
}
