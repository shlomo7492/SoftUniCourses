using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            PrintResultOfRounding(GetArray(numbers), GetRoundedArray(GetArray(numbers)));
        }
        static double [] GetArray(string numbers)
        {
            string[] stringArr = numbers.Split(' ');
            double[] newArr = new double[stringArr.Length];
            for (int i = 0; i < newArr.Length; i++)
            {
                newArr[i] = Convert.ToDouble (stringArr[i]);   
            }

            return newArr;
        }
        static double[] GetRoundedArray(double[] newArr)
        {
            for (int i = 0; i < newArr.Length; i++)
            {
                if ((newArr[i] * 10) % 5 == 0)
                {
                    if (newArr[i] < 0)
                    {
                        newArr[i] = Math.Floor(newArr[i]);
                    }
                    else
                    {
                        newArr[i] = Math.Ceiling(newArr[i]);
                    }
                }
                else
                {
                    newArr[i] = Math.Round(newArr[i]);
                }
            }
                return newArr;
        }
        static void PrintResultOfRounding(double[] firstArr, double[] roundedArr)
        {
            for (int i = 0; i < firstArr.Length; i++)
            {
                Console.WriteLine("{0} => {1}", firstArr[i], roundedArr[i]);
            }
        }
    }
}
