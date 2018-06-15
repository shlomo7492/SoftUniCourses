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
            Queue<int> queue = new Queue<int>();

            for (int i = 0; i <= int.Parse(commands[0]) - 1; i++)
            {
                queue.Enqueue(int.Parse(sequence[i]));
            }
            for (int i = 0; i <= int.Parse(commands[1]) - 1; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(int.Parse(commands[2])))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(MinQueueElement(queue));
            }

        }
        static int MinQueueElement(Queue<int> queue)
        {
            int minElement = int.MaxValue;
            int lim = queue.Count;
            for (int i = 1; i <= lim; i++)
            {
                if (minElement > queue.Peek())
                {
                    minElement = queue.Dequeue();
                }
            }
            return minElement;
        }
    }
}
