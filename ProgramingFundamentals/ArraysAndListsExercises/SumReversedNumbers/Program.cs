using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputLine = Console.ReadLine();
            string [] reversedStrArr = ReverseStringToArr(inputLine);
            Console.WriteLine(SumElementsFromString(reversedStrArr));
          
        }
        static string[] ReverseStringToArr(string inputLine)
        {
            char[] charArr = inputLine.ToCharArray();
            string reversedInput = "";
            for (int i = (charArr.Length-1); i >= 0; i--)
            {
                reversedInput += charArr[i];
            }
            return reversedInput.Split(' ');
        }
        static int SumElementsFromString(string[] reversedStr)
        {
            int sum = 0;
            for (int i = 0; i < reversedStr.Length; i++)
            {
                sum += int.Parse(reversedStr[i]);
            }
            return sum;
        }
    }
}
