using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Regex.Split(Console.ReadLine(), ", ")
                                .Select(int.Parse)
                                .ToArray();
            int[,] matrix = new int[rowCols[0], rowCols[1]];
            int sum = 0;
            for (int row = 0; row < rowCols[0]; row++)
            {
                int[] rowElements = Regex.Split(Console.ReadLine(), ", ")
                                .Select(int.Parse)
                                .ToArray();
                sum += rowElements.Sum();
                for (int col = 0; col < rowCols[1]; col++)
                {
                    matrix[row, col] = rowElements[col];
                }
            }
            Console.WriteLine(rowCols[0]);
            Console.WriteLine(rowCols[1]);
            Console.WriteLine(sum);
        }
    }
}
