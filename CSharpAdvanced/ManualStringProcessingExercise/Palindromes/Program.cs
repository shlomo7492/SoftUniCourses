using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(new char[] { ' ', ',', '?', '!', '.' }, StringSplitOptions.RemoveEmptyEntries);
            List<string> palindromes = new List<string>();
            foreach (var word in text.OrderBy(x=>x))
            {
                if (IsPalindrome(word))
                {
                    palindromes.Add(word);
                }
            }
            Console.WriteLine($"[{string.Join(", ",palindromes)}]");
        }
        static bool IsPalindrome(string word)
        {
            int n = word.Length;
            bool palindrome = true;
            for(int i=0;i<n/2;i++)
            {
                if(word[i]!=word[n-(1+i)])
                {
                    palindrome = false;
                    break;
                }
            }
            return palindrome;
        }
    }
}
