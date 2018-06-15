using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] numbers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                            .Select(int.Parse)
                                            .ToArray();
            while(true)
            {
                string command= Console.ReadLine();
                if (command == "add")
                {
                    numbers = Operation(numbers, num => num + 1);
                }
                else if (command == "subtract")
                {
                    numbers = Operation(numbers, num => num - 1);
                }
                else if (command == "multiply")
                {
                    numbers = Operation(numbers, num => num * 2);
                }
                else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
                else
                {
                    break;
                }

            }
            
        }
        static int[] Operation(int[] numbers, Func<int,int> operation)
        {
            for(int i=0;i<numbers.Length;i++)
            {
                numbers[i] = operation(numbers[i]);
            }
            return numbers;
        }
    }
}
