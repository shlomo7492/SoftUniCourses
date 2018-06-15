using System;
using System.Text.RegularExpressions;

namespace ЕxtractIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d+";
            string text = Console.ReadLine();

            Regex regex = new Regex(pattern);

            int count = regex.Matches(text).Count;
            if (count > 0)
            {
                foreach (Match match in regex.Matches(text))
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
