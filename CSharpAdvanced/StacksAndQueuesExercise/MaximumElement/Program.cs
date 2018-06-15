using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            Stack<int> maxValues = new Stack<int>();

            int maxElement = int.MinValue;
            for (int i = 1; i <= iterations; i++)
            {
                int [] command = Console.ReadLine()
                    .Split(new char[] { ' ' }
                    , StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                switch (command[0])
                {
                    case 1:
                        {
                            stack.Push(command[1]);
                            if (command[1] > maxElement)
                            {
                                maxElement = command[1];
                                maxValues.Push(maxElement);
                            }
                        }
                        break;
                    case 2:
                        {
                            if(stack.Pop()==maxElement)
                            {
                                maxValues.Pop();
                                if (maxValues.Count != 0)
                                {
                                    maxElement = maxValues.Peek();
                                }
                                else
                                {
                                    maxElement = int.MinValue;
                                }
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine(maxElement);
                        }
                        break;
                    default:break;

                }
            }
        }
    }
}
