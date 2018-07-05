using System;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            string[] stringArr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for(int i=stringArr.Length-1; i>=0;i--)
            {
                stack.Push(stringArr[i]);
            }
            string element = "";
            int result = 0;
            while(stack.Count !=0)
            {
                element = stack.Pop();
                switch (element)
                {
                    case "+":
                        {
                            result += int.Parse(stack.Pop());

                        }break;
                    case "-":
                        {
                            result -= int.Parse(stack.Pop());
                        }
                        break;
                    default:
                        {
                            result += int.Parse(element);
                        }
                        break;
                }

            }
            Console.WriteLine(result);
        }
    }
}
