using System;

namespace ConcatenateStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] text = new string[n];
            for (int i=0; i<n;i++)
            {
                text[i] = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", text));
        }
    }
}
