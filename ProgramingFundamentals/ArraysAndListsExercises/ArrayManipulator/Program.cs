using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] intArr = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
			GetAndExecuteComands(intArr);
		}
		static void GetAndExecuteComands(int[] intArr)
		{
			string[] inputLine;
			bool outVar = false;
			while (!outVar)
			{
				inputLine = Console.ReadLine().Split(' ');

				switch (inputLine[0])
				{
				case "add":
					{
						intArr = AddElement(int.Parse(inputLine[1]), int.Parse(inputLine[2]), intArr);
					}
					break;
				case "addMany":
					{
						int index = int.Parse(inputLine[1]);
						int[] elements = new int[inputLine.Length - 2];

						for (int i = 0; i < elements.Length; i++)
						{
							elements[i] = int.Parse(inputLine[i + 2]);
						}
						intArr = AddManyElements(index, elements, intArr);
					}
					break;
				case "contains":
					{
						Console.WriteLine(ContainsElement(intArr, int.Parse(inputLine[1])));
					}
					break;
				case "remove":
					{
						intArr = RemoveElementByIndex(intArr, int.Parse(inputLine[1]));
					}
					break;

				case "shift":
					{
						intArr = ShiftElementsPosition(intArr, int.Parse(inputLine[1]));
					}
					break;
				case "sumPairs":
					{
						intArr = SumElementsByPairs(intArr);
					}
					break;
				case "print":
					{
						PrintArray(intArr);
						outVar = true;
					}
					break;
				default:
					break;
				}
			}
		}
		static int[] AddElement(int index, int element, int[] intArr)
		{
			int[] newArr = new int[intArr.Length + 1];
			for (int i = 0; i < index; i++)
			{
				newArr[i] = intArr[i];            
			}
			newArr[index] = element;
			for (int i = index; i < intArr.Length; i++)
			{
				newArr[i+1] = intArr[i];
			}
			intArr = newArr;
			return newArr;
		}
		static int[] AddManyElements(int index, int[] elements, int[] intArr)
		{
			int[] newArr = new int[intArr.Length +elements.Length];

			for (int i = 0; i < index; i++)
			{
				newArr [i] = intArr [i];
			}

			for (int i = index; i < index+elements.Length; i++) 
			{
				newArr [i] = elements [i - index];						
			}

			for (int i = index; i < intArr.Length; i++) 
			{
				newArr [i + elements.Length] = intArr [i];
			}
			return newArr;
		}
		static int ContainsElement (int[] intArr, int value)
		{
			for (int i = 0; i < intArr.Length; i++)
			{
				if (intArr[i] == value)
				{
					return i;
				}
			}
			return -1;
		}
		static int[] RemoveElementByIndex(int[] intArr, int index)
		{
			int[] newArr = new int[intArr.Length - 1];
			newArr = intArr.Take(index).Concat(intArr.Skip(index+1).Take(newArr.Length-index)).ToArray() ;

			return newArr;
		}
		static int[] ShiftElementsPosition(int[] intArr, int positions)
		{
			for (int i = 1; i <= positions; i++)
			{
				GetRotatedElements(intArr);
			}
			return intArr;
		}
		static int[] GetRotatedElements(int[] intArr)
		{
			int tempValue = intArr[0];
			for (int i = 0; i < intArr.Length-1; i++)
			{
				intArr[i] = intArr[i + 1];
			}
			intArr[intArr.Length - 1] = tempValue;
			return intArr;
		}
		static int[] SumElementsByPairs(int[] intArr)
		{
			int[] newArr = new int[intArr.Length / 2];
			for (int i = 0; i < newArr.Length; i++)
			{ 
				newArr[i] = intArr[i*2]+intArr[i*2+1];
			}
			return newArr;
		}
		static void PrintArray(int[] intArr)
		{ 
			Console.WriteLine ("["+string.Join(", ",intArr)+"]");
		}
	}
}
