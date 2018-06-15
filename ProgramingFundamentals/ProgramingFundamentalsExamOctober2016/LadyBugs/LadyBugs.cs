using System;
using System.Linq;

namespace LadyBugs
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int fieldSize = int.Parse (Console.ReadLine ());
			bool[] fieldStatus = new bool[fieldSize];
			int[] ladyBugsPositions = Console.ReadLine ().Split ().Select (x => int.Parse (x)).ToArray ();
			//Console.WriteLine (string.Join ("-", ladyBugsPositions));
			for (int i = 0; i < fieldSize; i++) 
			{
				fieldStatus [i] = false;
			}
			foreach (int position in ladyBugsPositions) 
			{
				try
				{
					fieldStatus [position] = true;
				}
				catch
				{
				}
			}
			//Console.WriteLine (string.Join ("-", fieldStatus));
			string inputLine = Console.ReadLine ().ToLower();
			while (inputLine != "end") 
			{
				string[] moves = inputLine.Split ();
				int index = int.Parse (moves [0]);
				int move = int.Parse (moves [2]);
				if (move < 0) 
				{
					if (moves [1] == "right")
					{
						move = Math.Abs (move);
						moves[1]="left";
					} 
					else
					{
						move = Math.Abs (move);
						moves[1]="right";
					}
				}
				switch (moves [1]) 
				{
				case "right":
					{
						fieldStatus = GetMoveToRight (fieldStatus, index, move);
						//Console.WriteLine (string.Join ("-", fieldStatus));

					}
					break;
				case "left":
					{
						fieldStatus = GetMoveToLeft (fieldStatus, index, move);
						//Console.WriteLine (string.Join ("-", fieldStatus));
					}
					break;
				default:
					break;
				}

				inputLine = Console.ReadLine ().ToLower();
			}
			PrintFieldStatus (fieldStatus);
		}

		static bool[] GetMoveToRight(bool[] field, int index,int moveRange)
		{
			try
			{
				if (field [index] == true) 
				{
					field [index] = false;
					int newIndex = index + moveRange;
					while (newIndex < field.Length) 
					{
						if (field [newIndex] == false)
						{
							field [newIndex] = true;
							break;
						} 
						else
						{
							newIndex = newIndex + moveRange;
						}
					}
				}
			}
			catch
			{
			}
			return field;

		} 
		static bool[] GetMoveToLeft(bool[] field, int index,int moveRange)
		{
			try
				{
				if (field [index] == true) 
				{
					field [index] = false;
					int newIndex = index - moveRange;
					while (newIndex >= 0) 
					{
						if (field [newIndex] == false)
						{
							field [newIndex] = true;
							break;
						} 
						else
						{
							newIndex = newIndex - moveRange;
						}
					}
				}
			}
			catch
			{
			}
			return field;
		} 
		static void PrintFieldStatus(bool[] fieldStatus)
		{
			for (int i = 0; i < fieldStatus.Length; i++) 
			{
				if (fieldStatus [i] == true) 
				{
					Console.Write (1 + " ");
				}
				else 
				{
					Console.Write (0 +" ");
				}

			}
		}

	}
}
