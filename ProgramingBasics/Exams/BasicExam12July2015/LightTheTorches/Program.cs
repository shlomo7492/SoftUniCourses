using System;
using System.Text;

namespace LightTheTorches
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int basementRooms = int.Parse (Console.ReadLine ());
			string lightsOnOff = Console.ReadLine ();
			string allRoomStat = "";
			while (allRoomStat.Length < basementRooms)
			{
				for (int j = 0; j < lightsOnOff.Length; j++) 
				{
					if (allRoomStat.Length == basementRooms) 
					{
						break;
					}
					allRoomStat += lightsOnOff [j];

				}
			}
			StringBuilder tempStr = new StringBuilder(allRoomStat);

			string inputLine = Console.ReadLine ().ToUpper();
			int currentRoom = basementRooms / 2;
			int commandCount = 1;
			while ((inputLine != "END") && (commandCount <= 202))
			{
				string[] splited = inputLine.Split (' ');
				string direction = splited [0];
				int passedRooms = int.Parse (splited [1]);


				if (direction == "LEFT") 
				{
					currentRoom -= (passedRooms + 1);
					if (currentRoom < 0) 
						{
							currentRoom = 0;
						}

					if (tempStr [currentRoom] == 'L') 
					{
						tempStr [currentRoom] = 'D';
					} 
					else
					{
						tempStr [currentRoom] = 'L';
					}
				}
				if (direction == "RIGHT") 
				{
					currentRoom += (passedRooms + 1);
					if (currentRoom > tempStr.Length-1) 
						{
						currentRoom = tempStr.Length-1;
						}
					if (tempStr [currentRoom] == 'L') 
					{
						tempStr [currentRoom] = 'D';
					} 
					else 
					{
						tempStr [currentRoom] = 'L';
					}
				}
				inputLine = Console.ReadLine ().ToUpper();
				commandCount++;

			}
			int countDark = 0;
			for (int i = 0; i < tempStr.Length; i++) 
			{
				if (tempStr [i] == 'D')
				{
					countDark++;
				}
			}
			int prayers = countDark * 'D';
			Console.WriteLine (prayers);
		}
	}
}
