using System;

namespace ImpressGirlFriend
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			uint rubles = uint.Parse (Console.ReadLine ());
			uint dolars = uint.Parse (Console.ReadLine ());
			uint euros = uint.Parse (Console.ReadLine ());
			uint levaFirstSite = uint.Parse (Console.ReadLine ());
			uint levaSecondSite = uint.Parse (Console.ReadLine ());

			double biggerPrice = 0;
			if (((rubles / 100) * 3.5) >= biggerPrice) 
			{
				biggerPrice = (rubles / 100) * 3.5;
			}
			if ((dolars * 1.5) >= biggerPrice) 
			{
				biggerPrice= dolars * 1.5;
			}
			if ((euros * 1.95) >= biggerPrice) 
			{
				biggerPrice= euros * 1.95;
			}
			if ((levaFirstSite/2) >= biggerPrice) 
			{
				biggerPrice= levaFirstSite/2;
			}
			if (levaSecondSite >= biggerPrice) 
			{
				biggerPrice= levaSecondSite;
			}
			Console.WriteLine ("{0:f2}",Math.Ceiling (biggerPrice));
		}
	}
}
