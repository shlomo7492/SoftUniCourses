using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalTitles
{
    class PesonalTitles
    {
        public static void Main(string[] args)
        {
            float age = float.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            if (age < 16)
            {
                if (sex == "m")
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (sex == "m")
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
        }
    }
}
