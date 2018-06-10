using System;

namespace TheBetterMusicProducer
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int albumsEu = int.Parse (Console.ReadLine ());
			decimal priceEu = decimal.Parse (Console.ReadLine ());
			int albumsUs = int.Parse (Console.ReadLine ());
			decimal priceUs = decimal.Parse (Console.ReadLine ());
			int albumsLatin = int.Parse (Console.ReadLine ());
			decimal priceLatin = decimal.Parse (Console.ReadLine ());
			int numConcerts = int.Parse (Console.ReadLine ());
			decimal priceConcerts = decimal.Parse (Console.ReadLine ());
			decimal firstOffer = (((priceEu * albumsEu * 1.94m)+(priceUs*albumsUs*1.72m)+(priceLatin*albumsLatin/332.74m))*0.65m)*0.8m;
			decimal secondOffer = numConcerts * priceConcerts * 1.94m;
			if (secondOffer >= 100000)
			{
				secondOffer = secondOffer * 0.85m;
			}
			if (firstOffer > secondOffer) 
			{
				Console.WriteLine ("Let's record some songs! They'll bring us {0:f2}lv.", firstOffer);
			} 
			else
			{
				Console.WriteLine ("On the road again! We'll see the world and earn {0:f2}lv.", secondOffer);
			}
		}
	}
}
