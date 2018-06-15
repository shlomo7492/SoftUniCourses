using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNumber = int.Parse(Console.ReadLine());
            PrintDayOfTheWeek(dayNumber);
        }
        static string GetDay(int number) 
        {
            string[] dayName = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            return dayName[number-1];
        }
        static bool InvalidDayCheck(int number) 
        {
            if ((number > 7) || (number < 1))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        static void PrintDayOfTheWeek(int number) 
        {
            if (InvalidDayCheck(number))
            {
                Console.WriteLine(GetDay(number));
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
