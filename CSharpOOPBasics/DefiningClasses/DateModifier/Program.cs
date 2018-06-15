using System;
using System.Linq;

namespace DateModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string startDate = Console.ReadLine();
            string endDate = Console.ReadLine();
            string days =new DateDifference().GetDifference(startDate, endDate);
            Console.WriteLine(days);
        }
    }
    public class DateDifference
    {
        public string GetDifference(string firstDate, string endDate)
        {
            int[] date = firstDate.Split(' ').Select(int.Parse).ToArray();
            DateTime dateOne = new DateTime(date[0], date[1], date[2]);
            date = endDate.Split(' ').Select(int.Parse).ToArray();
            DateTime dateTwo = new DateTime(date[0], date[1], date[2]);

            TimeSpan difference = dateOne - dateTwo;
            return Math.Abs(difference.TotalDays).ToString();
        }
    }
}
