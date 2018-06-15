using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(string.Join("",Console.ReadLine().Reverse()));
            char[] input = Console.ReadLine().ToCharArray();
            Array.Reverse(input);
            Console.WriteLine(new String(input));
        }
    }
}
