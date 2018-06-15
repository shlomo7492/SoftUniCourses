using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>();
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                if (stack.Count == 0)
                {
                    stack.Push(input[i]);
                }
                else if(((stack.Peek()=='(') && (input[i]==')'))
                    || ((stack.Peek() == '[') && (input[i] == ']'))
                    || ((stack.Peek() == '{') && (input[i] == '}')))
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(input[i]);
                }
            }

            if (stack.Count == 0)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
