﻿using System;

class PriceChangeAlert
{
	static void Main()
	{
		int n = int.Parse(Console.ReadLine());

		double significance = double. Parse(Console.ReadLine());

		double lastPrice = double.Parse(Console.ReadLine());

		for (int i = 0; i < n - 1; i++) 
		{
			double currentPrice = double.Parse(Console.ReadLine());
			double difference = PercentDiference(lastPrice, currentPrice); 
			bool isSignificantDifference = imaliDif(difference, significance);
			string message = GetChangeMessage(currentPrice, lastPrice, difference, isSignificantDifference);
			Console.WriteLine(message);

			lastPrice = currentPrice; 
		}          
	}

	private static string GetChangeMessage(double currentPrice, double lastPrice, double difference, bool etherTrueOrFalse)
	{   
		string changeMessage = "";
		if (difference == 0) 
		{
			changeMessage = string.Format ("NO CHANGE: {0}", currentPrice);
		} 
		else if (!etherTrueOrFalse)
		{
			changeMessage = string.Format ("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
		}
		else if (etherTrueOrFalse && (difference > 0)) 
		{
			changeMessage = string.Format ("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
		} 
		else if (etherTrueOrFalse && (difference < 0))
		{
			changeMessage = string.Format ("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference);
		}
		return changeMessage;
	}

	private static bool imaliDif(double difference, double significance)
	{
		if (Math.Abs(difference) >= significance*100)
		{
			return true;
		}
		return false;
	}

	private static double PercentDiference(double lastPrice, double currentPrice)
	{
		double percent = ((currentPrice - lastPrice) / lastPrice)*100;
		return percent;
	}
}