using System;
using System.Text.RegularExpressions;

namespace NonDigitCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\D";
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            int count = regex.Matches(text).Count;
            Console.WriteLine("Non-digits: {0}", count);
        }
    }
}
