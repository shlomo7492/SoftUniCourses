using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            int divider = int.Parse(Console.ReadLine());
            Func<int, bool> operation = n => n % divider != 0;

            Console.WriteLine(OperationGetReversedAndExclude(numbers, operation));
        }
        static string OperationGetReversedAndExclude(int[] intArr, Func<int, bool> operation)
        {
            string line = "";
            for (int i = intArr.Length-1; i >= 0; i--)
            {
                if (operation(intArr[i]))
                {
                    line += intArr[i] + " ";
                }
            }
            return line;
        }
    }
}
