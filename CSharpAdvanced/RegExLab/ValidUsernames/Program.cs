using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([(a-zA-Z0123456789\-_)]+)";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
                Match match = regex.Match(line);
                if(match.Length<line.Length || match.Length <3 || match.Length>16)
                {
                    Console.WriteLine("invalid");
                }
                else
                {
                    Console.WriteLine("valid");
                }
            }
        }
    }
}
