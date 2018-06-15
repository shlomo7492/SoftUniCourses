using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<char, int> occurancies = new SortedDictionary<char, int>();
            foreach (char symbol in input)
            {
                if(occurancies.ContainsKey(symbol)==true)
                {
                    occurancies[symbol]++;
                }
                else
                {
                    occurancies.Add(symbol, 1);
                }
            }
            foreach (KeyValuePair<char,int> symbol in occurancies)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
