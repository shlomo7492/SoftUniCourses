using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumWithStep
{
    class SumWithStep
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sumOne = 0;
            int sumTwo = 0;
            int sumThree = 0;
            for (int i = 0; i < n; i += 3) 
            {
                sumOne = sumOne + arr[i];
            }
            for (int i = 1; i < n; i += 3)
            {
                sumTwo = sumTwo + arr[i];
            }
            for (int i = 2; i < n; i += 3)
            {
                sumThree = sumThree + arr[i];
            }
            Console.WriteLine("sum1 = "+sumOne);
            Console.WriteLine("sum2 = "+sumTwo);
            Console.WriteLine("sum3 = "+sumThree);
            Console.ReadKey();
        }
    }
}
