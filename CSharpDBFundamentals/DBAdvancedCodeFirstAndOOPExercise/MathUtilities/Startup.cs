using Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathUtilities
{
    class Startup
    {
        static void Main(string[] args)
        {
            double firstNumber = 0;
            double secondNumber = 0;
            double result = 0;

            string[] input = Console.ReadLine().Split(' ').ToArray();
            while (input[0].ToLower() != "end")
            {
                firstNumber = double.Parse(input[1]);
                secondNumber = double.Parse(input[2]);
                switch (input[0].ToLower())
                {
                    case "sum":
                        {
                            Console.WriteLine($"{MathUtil.Sum(firstNumber,secondNumber):f2}");
                        }
                        break;
                    case "subtract":
                        {
                            Console.WriteLine($"{MathUtil.Subtract(firstNumber, secondNumber):f2}");
                        }
                        break;
                    case "multiply":
                        {
                            Console.WriteLine($"{MathUtil.Multiply(firstNumber, secondNumber):f2}");
                        }
                        break;
                    case "divide":
                        {
                            Console.WriteLine($"{MathUtil.Divide(firstNumber, secondNumber):f2}");
                        }
                        break;
                    case "percentage":
                        {
                            Console.WriteLine($"{MathUtil.Percentage(firstNumber, secondNumber):f2}");
                        }
                        break;
                    default:break;
                }
                input = Console.ReadLine().Split(' ').ToArray();
            }
        }
    }
}
