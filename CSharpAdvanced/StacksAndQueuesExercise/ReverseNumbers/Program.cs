using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            string[] sequence = Console.ReadLine()
                                    .Split(new char[] { ' ' }, 
                                           StringSplitOptions.RemoveEmptyEntries);
            foreach (string number in sequence)
            {
                stack.Push(int.Parse(number));
            }
            for(int i=0;i<sequence.Length;i++)
            {
                Console.Write(stack.Pop()+" ");
            }
            Console.WriteLine();
        }
    }
}
