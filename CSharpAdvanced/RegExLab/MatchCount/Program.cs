using System;
using System.Text.RegularExpressions;

namespace MatchCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine();
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            int count = regex.Matches(text).Count;
            Console.WriteLine(count);
        }
    }
}
