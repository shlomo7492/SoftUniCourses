using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MatchPhoneNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\+\d{3} \d? \d{3} \d{4})|(\+\d{3}\-\d?\-\d{3}\-\d{4})";
            while (true)
            {

                string phoneNum = Console.ReadLine();
                if (phoneNum == "end")
                {
                    break;
                }
                Regex regex = new Regex(pattern);
                Match match = regex.Match(phoneNum);
                if (match.ToString() != "")
                {
                    Console.WriteLine(match);
                }

            }
        }
    }
}
