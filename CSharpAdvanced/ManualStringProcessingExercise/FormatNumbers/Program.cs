using System;

namespace FormatNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(new char[] { },StringSplitOptions.RemoveEmptyEntries);
            var firstColumn = Convert.ToString(int.Parse(input[0]), 16).PadRight(10,' ').ToUpper();
            var secondColumn = Convert.ToString(int.Parse(input[0]), 2).PadLeft(10, '0');
            secondColumn = secondColumn.Substring(0, 10);
            var thirdColumn = string.Format($"{double.Parse(input[1]),+10:f2}");
            var fourthColumn = string.Format($"{double.Parse(input[2]),-10:f3}");
            Console.WriteLine($"|{firstColumn}|{secondColumn}|{thirdColumn}|{fourthColumn}|");
        }
    }
}
