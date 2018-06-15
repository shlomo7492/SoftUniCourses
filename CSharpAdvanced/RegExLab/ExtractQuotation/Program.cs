using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractQuotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\'.*?\')|(\'(\'.*?\')\')|(\"".*?\"")|(\""(\'.*?\')\"")|(\'.*?\')|(\'(\"".*?\"")\')|(\"".*?\"")|(\""(\"".*?\"")\"")";

            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            foreach (Match match in regex.Matches(text))
            {
                int length = match.ToString().Trim().Length;
                Console.WriteLine(match.ToString().Trim().Substring(1,length-2));
            }

        }
    }
}
