using System;

namespace BohemchoTheBadGhost
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int counter = 0;
			string inputLine = Console.ReadLine ();
			uint floorStat = 0;
			int lightOnCount = 0;
			ulong score = 0;
			while (inputLine != "Stop, God damn it") 
			{
				if (counter % 2 == 0) 
				{
					floorStat = uint.Parse (inputLine);
				} 
				else
				{
					string[] splited = inputLine.Split (' ');
					int apartment = 0;
					for (int i = 0; i <= splited.Length - 1; i++) 
					{
						apartment = int.Parse (splited [i]);
						uint changer = 1u << apartment;
						floorStat = floorStat ^ changer;
					}
					for (int i = 0; i <= 31; i++) 
					{
						uint changer = 1u << i;
						if ((floorStat & changer) > 0)
						{
							lightOnCount++;
						} 
										
					}
					score += floorStat;
				}
				counter++;
				inputLine = Console.ReadLine ();

			}
			Console.WriteLine ("Bohemcho left {0} lights on and his score is {1}", lightOnCount, score);
		}
	}
}
