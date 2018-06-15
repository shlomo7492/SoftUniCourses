using System;
using System.Collections.Generic;

namespace BasicStackOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine()
                                        .Split(new char[] { ' ' },
                                          StringSplitOptions.RemoveEmptyEntries);
            string[] sequence = Console.ReadLine()
                                        .Split(new char[] { ' ' },
                                          StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i <= int.Parse(commands[0])-1; i++)
            {
                stack.Push(int.Parse(sequence[i]));
            }
            for (int i = 0; i <= int.Parse(commands[1]) - 1; i++)
            {
                stack.Pop();
            }
            if (stack.Contains(int.Parse(commands[2])))
            {
                Console.WriteLine("true");
            }
            else if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(MinStackElement(stack));
            }

        }
        static int MinStackElement(Stack<int> stack)
        {
            int minElement = int.MaxValue;
            int lim = stack.Count;
            for (int i = 1; i <= lim; i++)
            {
                if (minElement > stack.Peek())
                {
                    minElement = stack.Pop();
                }
            }
            return minElement;
        }
    }
}
