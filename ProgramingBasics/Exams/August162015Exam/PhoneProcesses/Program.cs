using System;

namespace PhoneProcesses
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string inputLine = Console.ReadLine ();
			int batteryPower = int.Parse (inputLine.Split('%')[0]);
			inputLine = Console.ReadLine ();
			int appCount = 0;
			while (inputLine.ToLower() != "end") 
			{
				appCount++;
				if (batteryPower > 15) 
				{
					batteryPower -= batteryPower + int.Parse ((inputLine [inputLine.Length - 3].ToString() + inputLine [inputLine.Length - 2].ToString()));
					appCount--;
				}
				inputLine = Console.ReadLine ();
			}
			if (batteryPower > 15) 
			{
				Console.WriteLine ("Successful complete -> {0}%", batteryPower);
			} 
			else if (batteryPower > 0) 
			{
				Console.WriteLine ("Connect charger -> {0}% \nPrograms left -> {1}", batteryPower,appCount);
			} 
			else 
			{
				Console.WriteLine ("Phone Off");
			}

		}
	}
}
