using System;
using System.Collections.Generic;

namespace MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> bracketIndexes = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    bracketIndexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int leftIndex = bracketIndexes.Pop();
                    Console.WriteLine(expression.Substring(leftIndex, (i-leftIndex+1)));
                }
            }
        }
    }
}
