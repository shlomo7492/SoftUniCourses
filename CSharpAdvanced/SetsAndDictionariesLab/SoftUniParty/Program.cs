using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> snoobs = new SortedSet<string>();
            SortedSet<string> regular = new SortedSet<string>();

            string input = Console.ReadLine();

            while(input != "PARTY")
            {
                if(IsSnoob(input))
                {
                    snoobs.Add(input);
                }
                else
                {
                    regular.Add(input);
                }
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input !="END")
            {
                if (IsSnoob(input))
                {
                    snoobs.Remove(input);
                }
                else
                {
                    regular.Remove(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(snoobs.Count+regular.Count);
            foreach (string guest in snoobs)
            {
                Console.WriteLine(guest);
            }
            foreach (string guest in regular)
            {
                Console.WriteLine(guest);
            }
        }
        static bool IsSnoob(string input)
        {
            int i;
            return int.TryParse(""+input[0],out i);
        }
    }
}
