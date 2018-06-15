using System;
using System.Text.RegularExpressions;

namespace ExtractTags
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(<[a-zA-Z0123456789\'\""\=\-\!\/\s]+>)";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                if (regex.Matches(line).Count > 0)
                {
                    foreach (Match match in regex.Matches(line))
                    {
                        Console.WriteLine(match);
                    }
                }
            }
       
        }
    }
}
