using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppendLists
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            PrintAllListsInReverseOrder(numbers);
        }
        static IList<int> GetList(string numbers)
        {
            char[] empty = new char[] { ' ' };
            var inputList = numbers.Split(empty ,StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            return inputList;
        }

        static string[] GetEachList(string inputLine)
        {
            string[] stringArr = inputLine.Split('|');
            return stringArr;
        }
        static void PrintList(IList<int> separetedList)
        {
            for (int i=0;i<separetedList.Count;i++)        
            {
                if (i == 0)
                {
                    Console.Write(separetedList[i]);
                }
                else 
                {
                    Console.Write(" " + separetedList[i]);
                }
            }
        }
        static void PrintAllListsInReverseOrder(string numberLine)
        {
            string[] arrOfLists = GetEachList(numberLine);
            for (int i = arrOfLists.Length - 1; i >= 0; i--)
            {
                PrintList(GetList(arrOfLists[i]));
                Console.Write(" ");
            }
        }

    }
}
