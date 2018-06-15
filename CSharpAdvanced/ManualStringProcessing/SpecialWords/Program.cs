using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] specialWords = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> specialWordsOccurrences = new Dictionary<string, int>();
            foreach (var word in specialWords)
            {
                specialWordsOccurrences.Add(word, 0);
            }
            string[] text = Console.ReadLine()
                .Split(new char[] { '(', ')', '[', ']', '<', '>', ',', '-', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in text)
            {
                if(specialWordsOccurrences.ContainsKey(word))
                {
                    specialWordsOccurrences[word]++;
                }
            }
            foreach (var word in specialWordsOccurrences)
            {
                Console.WriteLine($"{word.Key} - {word.Value}");
            }
        }
    }
}

