using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfTheWeek
{
    class DaysOfTheWeek
    {
        static void Main(string[] args)
        {
            string[] daysOfTheWeek = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int dayNum = int.Parse(Console.ReadLine());
            if ((dayNum >= 1) && (dayNum <= 7))
            {
                Console.WriteLine(daysOfTheWeek[dayNum - 1]);
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}
