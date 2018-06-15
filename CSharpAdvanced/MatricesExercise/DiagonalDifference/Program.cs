using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] square = new int[n, n];

            for (int row=0;row<n;row++)
            {
                int[] inputLine = Console.ReadLine()
                                         .Split(new char[]{ ' '},StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToArray();
                for (int col = 0; col < n; col++)
                {
                    square[row, col] = inputLine[col];
                }
            }
            int firstDiagonal = 0;
            int secondDiagonal = 0;
            for(int row=0;row<n;row++)
            {
                firstDiagonal += square[row, row];
                secondDiagonal += square[row, n-1-row];
            }
            Console.WriteLine(Math.Abs(firstDiagonal-secondDiagonal));
        }
    }
}
