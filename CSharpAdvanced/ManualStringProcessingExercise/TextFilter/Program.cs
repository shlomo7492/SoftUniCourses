using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] banList = Regex.Split(Console.ReadLine(), ", ");
            string text = Console.ReadLine();

            StringBuilder sbText = new StringBuilder(text);
            foreach (string banWord in banList)
            {
                sbText.Replace(banWord, new string('*', banWord.Length));
            }
            Console.WriteLine(sbText.ToString());
        }
    }
}
