using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int bankHollidays = int.Parse(Console.ReadLine());
            int homeReturn = int.Parse(Console.ReadLine());

            if (yearType == "normal")
            {
                Console.WriteLine((int)(((48 - homeReturn) * (3 / 4.0)) + (bankHollidays * (2 / 3.0)) + homeReturn));
            }
            else if (yearType == "leap")
            {
                Console.WriteLine("{0}",(int)((((48 - homeReturn) * (3 / 4.0)) + (bankHollidays * (2 / 3.0)) + homeReturn)*1.15));
            }
            Console.ReadKey();
        }
    }
}
