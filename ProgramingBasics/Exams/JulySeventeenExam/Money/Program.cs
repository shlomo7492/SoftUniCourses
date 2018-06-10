using System;

namespace Money
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int bitcoinAmount = int.Parse (Console.ReadLine ());
			double yuanAmount = double.Parse (Console.ReadLine ());
			double commision = double.Parse (Console.ReadLine ());

			Console.WriteLine ((((bitcoinAmount*1168.0)+((yuanAmount*0.15)*1.76))/1.95)*(1.0-(commision/100)));
		}
	}
}
