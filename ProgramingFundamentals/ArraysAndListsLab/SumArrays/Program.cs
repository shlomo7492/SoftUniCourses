using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstLineOfNumbers = Console.ReadLine();
            string secondLineOfNumbers = Console.ReadLine();
            PrintResultArray(GetSumArrayElements(GetArray(firstLineOfNumbers),GetArray(secondLineOfNumbers)));
        }
        static int[] GetArray(string numbers)
        {
            string[] stringArr = numbers.Split(' ');
            int[] newArr = new int[stringArr.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = int.Parse(stringArr[i]);
            }

            return newArr;
        }
        static int[] GetSumArrayElements(int[] firstArr, int[] secondArr)
        { 
            if (firstArr.Length<secondArr.Length)
            {
                secondArr = ArraySum (GetDuplicateSmallerArray(firstArr,secondArr.Length),secondArr);
                return secondArr;
            }
            else if (firstArr.Length > secondArr.Length)
            {
                firstArr = ArraySum(firstArr,GetDuplicateSmallerArray(secondArr, firstArr.Length));
                return firstArr;
            }
            else 
            {
                firstArr = ArraySum (firstArr, secondArr);
                return firstArr;
            }
            
        }
        static int[] GetDuplicateSmallerArray(int[] smallerArr, int number)
        {
            int[] biggerArr = new int[number];

            for (int i = 0; i <= number/smallerArr.Length; i++)
            {
                for (int j = 0; j < smallerArr.Length; j++)
                {
                    if ((i * smallerArr.Length + j) >= biggerArr.Length)
                    {
                        break;
                    }
                    biggerArr[i * smallerArr.Length + j] = smallerArr[j];
                }
            }
            return biggerArr;
        }
        static int[] ArraySum(int[] first, int[] second)
        {
            for (int i = 0; i < first.Length; i++)
            {
                first[i] += second[i];
            }
            return first;
        }
        static void PrintResultArray(int[] resultArr)
        {
            for (int i = 0; i < resultArr.Length; i++)
            {
                if (i == 0)
                {
                    Console.Write(resultArr[i]);
                }
                else 
                {
                    Console.Write(" " + resultArr[i]);
                }
            }
        }
    }
}
