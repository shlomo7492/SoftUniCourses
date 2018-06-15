using System;
using System.Linq;

namespace CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] strArr = 
                Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                                                .Select(n => (n[0].ToString() == n[0].ToString().ToUpper()) ? n : "")
                                                .Where(n=>n!="")
                                                .ToList()
                                                .ForEach(n => Console.WriteLine(n));

        }
    }
}
