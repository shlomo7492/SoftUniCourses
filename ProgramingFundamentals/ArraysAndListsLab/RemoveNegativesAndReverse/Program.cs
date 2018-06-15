using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            PrintReversedPositiveList(GetListAndRemoveNegative(inputLine));
        }
        static IList<int> GetListAndRemoveNegative(string inputLine)
        {
            var inputList = inputLine.Split(' ').Select(int.Parse).ToList();
            List<int> positiveList =new  List<int>();
            foreach (int num in inputList)
            {
                if (num >= 0)
                {
                    positiveList.Add(num);
                }
            }
            return positiveList;
           
        }
        static void PrintReversedPositiveList(IList <int> positive) 
        {
            if (positive.Count == 0)
            {
                Console.Write("empty");
            }
            else
            {
                Console.Write(positive[positive.Count - 1]);
                for (int i = positive.Count - 2; i >= 0; i--)
                {
                    Console.Write(" " + positive[i]);
                }
            }
        }
    }
}
