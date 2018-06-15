using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseArrayOfIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] numArr = new int[number];
            numArr = ReverseArrayElements(GetArray(number));
            PrintArray(numArr);
        }
        static int[] ReverseArrayElements(int[] numArr) 
        {
            int tempNum;
            for (int i = 0; i <= numArr.Length - 1; i++) 
            {

                tempNum = numArr[i];
                numArr[i] = numArr[numArr.Length - 1 - i];
                numArr[numArr.Length - 1 - i] = tempNum;
                if ((numArr.Length - 1) / 2 == i) 
                {
                    break; 
                }
            }
                return numArr;
        }
        static int[] GetArray(int number) 
        {
            int[] numArr = new int[number];
            for (int i=0;i<number;i++)
            {
                numArr[i]=int.Parse(Console.ReadLine());
            }
            return numArr;
        }
        static void PrintArray(int[] numArr)
        {
            for (int i = 0; i < numArr.Length; i++)
            {
                if (i > 0)
                {
                    Console.Write(" " + numArr[i]);
                }
                else 
                {
                    Console.Write(numArr[i]);
                }
            }
        }
    }
}
