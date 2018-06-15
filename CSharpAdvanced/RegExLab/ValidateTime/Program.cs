using System;
using System.Text.RegularExpressions;

namespace ValidateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([0-9]{2,2}:)+[0-9]{2,2} [A|P]{1,1}M";
            Regex regex = new Regex(pattern);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
                Match match = regex.Match(line);
                string[] time = match.ToString()
                                     .Split(new[] { ":", " " }, StringSplitOptions.RemoveEmptyEntries);
                if(match.Length <line.Length||int.Parse(time[0])>11
                                            ||int.Parse(time[0])<0
                                            ||int.Parse(time[1])>59
                                            ||int.Parse(time[1])<0
                                            || int.Parse(time[2]) > 59
                                            || int.Parse(time[2]) < 0)
                {
                    Console.WriteLine("invalid");
                }
                else if(int.Parse(time[0])==0 && time[3]=="PM")
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
