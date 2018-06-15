using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvensOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] border = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            Func<int, bool> operationEven = n => n % 2 == 0;
            Func<int, bool> operationOdd = n => n % 2 != 0;

            switch (Console.ReadLine())
            {
                case "even":
                    {
                        Console.WriteLine(OperationGetEvenOrOdds(border[0], border[1], operationEven));
                    }
                    break;
                case "odd":
                    {
                        Console.WriteLine(OperationGetEvenOrOdds(border[0], border[1], operationOdd));
                    }
                    break;
                default:
                    break;
            }

        }
        static string OperationGetEvenOrOdds(int start, int end, Func<int, bool> operation)
        {
            string line = "";
            for (int i = start; i <= end; i++)
            {
                if (operation(i))
                {
                    line += i + " ";
                }
            }
            return line;
        }
    }
}
