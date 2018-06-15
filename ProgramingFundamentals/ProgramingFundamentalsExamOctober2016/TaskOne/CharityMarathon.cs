using System;

namespace CharityMarathon
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			long marathonDays = long.Parse (Console.ReadLine ());
			if (marathonDays > 365) 
			{
				marathonDays = 365;
			}
			long runners = long.Parse (Console.ReadLine ());
			if (runners > int.MaxValue) 
			{
				runners = int.MaxValue;
			}
			long averageLaps = long.Parse (Console.ReadLine ());
			if (averageLaps > 100) 
			{
				averageLaps = 100;
			}
			long trackLength = long.Parse (Console.ReadLine ());
			if (trackLength > int.MaxValue) 
			{
				trackLength = int.MaxValue;
			}
			long trackCapacity = long.Parse (Console.ReadLine ());
			if (trackCapacity > 1000) 
			{
				trackCapacity = 1000;
			}
			decimal donationPerKm = decimal.Parse (Console.ReadLine ());

			long averageRunningDistance = GetAverageRunningDistance (averageLaps, trackLength);

			runners = SetTotalRunners (trackCapacity, runners, marathonDays);

			decimal totalDistance = GetTotalDistance (runners, averageRunningDistance);

			decimal totalMoneyRised = GetAllMoneyRised (totalDistance, donationPerKm);

			PrintDonationsRised (totalMoneyRised);
		}
		static long GetAverageRunningDistance(long averageLaps,long trackLength)
		{
			if ((averageLaps <= 0)||(trackLength<=0))
			{
				return 0;
			}
			return trackLength * averageLaps;
		}

	
		static long SetTotalRunners (long trackCapacity, long runners, long marathonDays)
		{
			if (trackCapacity * marathonDays > runners)
			{
				return runners;				
			} 
			else if ((marathonDays <= 0)||(trackCapacity <= 0)) 
			{
				return 0;
			} 
			else 
			{
				return trackCapacity * marathonDays;
			}

		}

		static decimal GetTotalDistance(long runners, long averageDistance)
		{
			return (decimal)runners * (decimal)averageDistance/1000;
		}

		static decimal GetAllMoneyRised(decimal totalDistance, decimal donationPerKm)
		{
			return totalDistance * donationPerKm;
		}

		static void PrintDonationsRised(decimal totalMoneyRised)
		{
			Console.WriteLine ($"Money raised: {totalMoneyRised:f2}");
		}
	}
}
