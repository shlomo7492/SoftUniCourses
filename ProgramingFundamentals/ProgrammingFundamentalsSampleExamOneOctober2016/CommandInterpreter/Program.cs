using System;
using System.Linq;

namespace CommandInterpreter
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] inputCollection = Console.ReadLine ().Split (new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
			string[] command = Console.ReadLine ().ToLower().Split();
			int index = 0;
			int count = 0;
			bool isValid = false;
			while (command[0] != "end") 
			{
				string currentCommand = command [0];

				if (command.Length == 5) 
				{
					try 
					{
						index = int.Parse (command [2]);
						count = int.Parse (command [4]);
						if (((index>=0)&&(index<=inputCollection.Length-1))
							&&((count>=0)&&(count+index<=inputCollection.Length-1)))
						{
							isValid=true;
						}
					}
					catch
					{
						Console.WriteLine ("Invalid input parameters.");
					}
				} 
				else 
				{
					try 
					{
						count = int.Parse (command [1]);
						if ((count>=0)&&(count<=int.MaxValue))
						{
							isValid=true;
						}
					}
					catch
					{
						Console.WriteLine ("Invalid input parameters.");
					}
				}
				if (isValid)
				{
					switch (currentCommand)
					{
						case "reverse":
							{
								inputCollection = GetReversedArrayByPortion (inputCollection, index, count);

							}
							break;
						case "sort":
							{
								inputCollection = GetSortedArrayByPortion (inputCollection, index, count);

							}
							break;
						case "rollleft":
							{
							
								inputCollection = GetLeftRotatedArray (inputCollection, count);

							}
							break;
						case "rollright":
							{
								inputCollection = GetRightRotatedArray (inputCollection, count);

							}
							break;
						default:
							break;
					}
				}
				else
				{
					Console.WriteLine ("Invalid input parameters.");
				}
				command = Console.ReadLine ().ToLower().Split();
			}
			Console.WriteLine("[" + string.Join(", ",inputCollection) + "]");
		}

		static string[] GetReversedArrayByPortion(string[] strArr,int start,int count)
		{
			string[] collectionPortion = new string[count];
			for (int i = 0; i < count; i++) 
			{
				collectionPortion [i] = strArr [start + i];
			}
			Array.Reverse(collectionPortion);			

			for (int i = 0; i < count; i++) 
			{
				strArr [start + i] = collectionPortion [i];
			}
			return strArr;
		}

		static string[] GetSortedArrayByPortion(string[] strArr,int start,int count)
		{
			string[] collectionPortion = new string[count];
			for (int i = 0; i < count; i++) 
			{
				collectionPortion [i] = strArr [start + i];
			}
			Array.Sort (collectionPortion);
			for (int i = 0; i < count; i++) 
			{
				strArr [start + i] = collectionPortion [i];
			}
			return strArr;
		}

		static string[] GetLeftRotatedArray(string[] strArr,int count)
		{
			for (int i = 1; i <= count; i++) 
			{
				string tempValue = strArr [0];
				for (int k = 0; k < strArr.Length-1; k++) 
				{
					strArr [k] = strArr [k + 1];
				}
				strArr [strArr.Length - 1] = tempValue;
			}
			return strArr;
		}

		static string[] GetRightRotatedArray(string[] strArr,int count)
		{
			for (int i = 1; i <= count; i++) 
			{
				string tempValue = strArr [strArr.Length - 1];
				for (int k = (strArr.Length - 1); k >= 1; k--) 
				{
					strArr [k] = strArr [k - 1];
				}
				strArr [0] = tempValue;
			}
			return strArr;
		}

	}
}
