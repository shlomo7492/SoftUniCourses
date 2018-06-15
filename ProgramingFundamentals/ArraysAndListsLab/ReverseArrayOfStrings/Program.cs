using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            PrintReversedArray(ReverseArrayElements(GetArray(inputString)));
        }
        static string[] GetArray(string inputString)
        {
            string[] stringArr = inputString.Split(' ');
            return stringArr;
        }
        static string[] ReverseArrayElements(string[] stringArr)
        {
            string tempString;
            for (int i = 0; i <= stringArr.Length - 1; i++)
            {

                tempString = stringArr[i];
                stringArr[i] = stringArr[stringArr.Length - 1 - i];
                stringArr[stringArr.Length - 1 - i] = tempString;
                if ((stringArr.Length - 1) / 2 == i)
                {
                    break;
                }
            }
            return stringArr;
        }
        static void PrintReversedArray(string[] stringArr)
        {
            for (int i = 0; i < stringArr.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(stringArr[i]);
                }
                else 
                {
                    Console.Write(" " + stringArr[i]);
                }
            }
        }
    }
}
