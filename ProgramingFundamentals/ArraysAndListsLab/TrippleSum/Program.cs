using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrippleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            PrintAllSums(GetArray(numbers));

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
      
        static void PrintAllSums(int[] newArr)
        {
            bool isTrue = false;
            for (int i = 0; i < newArr.Length; i++)
            {
                for (int j = i+1; j < newArr.Length; j++)
                {
                    for (int k = 0; k < newArr.Length; k++)
                    {
                            if ((newArr[i] + newArr[j]) == newArr[k])
                            {
                                Console.WriteLine("{0} + {1} == {2}", newArr[i], newArr[j], newArr[k]);
                                isTrue = true;
                                break;
                            }

                     }
                                    
                }
            }
            if (!isTrue)
            {
                Console.WriteLine("No");
            }
        }
    }
}
