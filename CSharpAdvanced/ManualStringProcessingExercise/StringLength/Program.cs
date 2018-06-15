using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            if(text.Length<20)
            {
                text += new string('*', 20 - text.Length);
            }
            Console.WriteLine(text);
        }
    }
}
