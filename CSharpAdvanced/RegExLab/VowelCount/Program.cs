using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[AaEeIiOoUuYy]";
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            int count = regex.Matches(text).Count;
            Console.WriteLine("Vowels: {0}",count);
        }
    }
}
