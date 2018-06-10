using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlusFifteenMinutes
{
    class TimePlusFifteen
    {
        static void Main(string[] args)
        {
            var hours = int.Parse(Console.ReadLine());
            var minutes = int.Parse(Console.ReadLine());
            hours = hours + (minutes + 15) / 60;
            if (hours == 24)
            {
                hours = 0;
            }
            else if (hours > 24)
            {
                hours = hours - 24;
            }
            minutes = (minutes + 15) % 60;
            Console.WriteLine("{0:#0}:{1:00}", hours, minutes);
            Console.ReadKey();
        }
    }
}
