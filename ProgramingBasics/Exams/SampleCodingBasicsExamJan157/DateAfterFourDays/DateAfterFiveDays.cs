using System;

namespace DateAfterFiveDays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var day = int.Parse(Console.ReadLine());
            var month = int.Parse(Console.ReadLine());
            var year = 2015;

            DateTime date = new DateTime(year, month, day);

            DateTime fourDaysLater = date.AddDays(5);
            Console.WriteLine(fourDaysLater.ToString("d.MM"));
            Console.ReadKey();
        }
    }
}
