using System;
using System.Linq;

namespace SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNum = Console.ReadLine();
            string secondNum = Console.ReadLine();
            if (firstNum.Length > secondNum.Length)
            {
                Console.WriteLine(SumElements(firstNum,secondNum)); 
            }
            else
            {
                Console.WriteLine(SumElements(secondNum, firstNum)); 
            }

        }
        static string SumElements (string firstNum,string secondNum)
        {
            int diff = firstNum.Length - secondNum.Length;
            int[] intArr = new int[firstNum.Length+1];
            for (int i = 1; i <= firstNum.Length; i++)
            {
                intArr[i] = int.Parse(firstNum[i-1] + "");
            }
            for (int i = secondNum.Length - 1; i >= 0; i--)
            {
                intArr[i + diff + 1] += int.Parse(secondNum[i] + "");
            }
            for (int i = firstNum.Length; i > 0; i--)
            {
                if (intArr[i] >= 10)
                {
                    intArr[i] -= 10;
                    intArr[i-1]++;
                }
            }
            return string.Join("",intArr[0]==0?intArr.Skip(1):intArr);
        }
    }
}
