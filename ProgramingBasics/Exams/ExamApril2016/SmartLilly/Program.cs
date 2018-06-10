using System;

namespace SmartLilly
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int age = int.Parse (Console.ReadLine ());
			float washingMachine = float.Parse (Console.ReadLine ());
			int toyPrice = int.Parse (Console.ReadLine ());

			int toyCount = 0;
			float moneyCount = 0f;
			for (int i = 1; i <= age; i++) 
			{
				if (i % 2 == 0) 
				{
					moneyCount += ((i * 5f)-1f);
				} 
				else 
				{
					toyCount += 1;	
				}
			}
			moneyCount += toyCount*toyPrice;

			if (moneyCount >= washingMachine) 
			{
				Console.WriteLine ("Yes! {0:f2}",moneyCount-washingMachine);
			} 
			else 
			{
				Console.WriteLine ("No! {0:f2}",washingMachine-moneyCount);
			}
		}
	}
}
