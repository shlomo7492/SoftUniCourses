using System;
using System.Linq;

namespace CountSubstringOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            string subStr = Console.ReadLine();
            int count = 0;
            while(text.IndexOf(subStr)>-1)
            {
                count++;
                text = string.Join("", text.Skip(text.IndexOf(subStr)+1));
            }
            Console.WriteLine(count);
        }
    }
}
