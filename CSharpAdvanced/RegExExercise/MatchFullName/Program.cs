using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z][a-z]+ [A-Z][a-z]+";
            while (true)
            {
                
                string name = Console.ReadLine();
                if (name == "end")
                {
                    break;
                }
                Regex regex = new Regex(pattern);
                Match match = regex.Match(name);
                if(match.ToString() != "")
                {
                    Console.WriteLine(match);
                } 
            
            }
        }
    }
}
