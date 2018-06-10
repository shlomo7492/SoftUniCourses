using System;

namespace GrandTheftExamo
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int attemts = int.Parse (Console.ReadLine ());
			long totalBeers = 0;
			long totalTiefs = 0;
			long slaped = 0;
			for (int i = 1; i <= attemts; i++) 
			{
				long tiefs = long.Parse (Console.ReadLine ());
				long beers = long.Parse (Console.ReadLine ());
				totalBeers += beers;
				totalTiefs += tiefs;
				if (tiefs >= 5) 
				{
					slaped = slaped + 5;
				}
				else
				{
					slaped = slaped + tiefs;
				}
			}
			Console.WriteLine ("{0} thieves slapped.", slaped);
			Console.WriteLine ("{0} thieves escaped.", totalTiefs - slaped);
			Console.WriteLine ("{0} packs, {1} bottles.", totalBeers / 6, totalBeers % 6);
		}
	}
}
