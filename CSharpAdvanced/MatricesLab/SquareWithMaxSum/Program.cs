using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace SquareWithMaxSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCols = Regex.Split(Console.ReadLine(), ", ")
                                 .Select(int.Parse)
                                 .ToArray();
            int[,] matrix = SetMatrix(rowCols[0], rowCols[1]);
            PrintBigestTopLeftSquare(matrix);
        }
        static void PrintBigestTopLeftSquare(int[,] matrix)
        {
            int[,] square = new int[2, 2];
            int[,] maxSquare = new int[2, 2];
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    square = GetSquareTwoByTwo(row, col, matrix);
                    if (GetSquareSum(square) > sum)
                    {
                        sum = GetSquareSum(square);
                        maxSquare = square;
                    }
                }
            }
            Console.WriteLine(maxSquare[0, 0] + " " + maxSquare[0, 1]);
            Console.WriteLine(maxSquare[1, 0] + " " + maxSquare[1, 1]);
            Console.WriteLine(sum);
        }
        static int[,] SetMatrix(int row, int col)
        {
            int[,] matrix = new int[row, col];
            for (int i = 0; i < row; i++)
            {
                int[] rowElements = Regex.Split(Console.ReadLine(), ", ")
                                        .Select(int.Parse)
                                        .ToArray();

                for (int j = 0; j < col; j++)
                {
                    matrix[i, j] = rowElements[j];
                }
            }
            return matrix;
        }
        static int[,] GetSquareTwoByTwo(int row,int col, int[,] matrix)
        {
            int[,] square = new int[2, 2];
            square[0, 0] = matrix[row, col];
            square[0, 1] = matrix[row, col + 1];
            square[1, 0] = matrix[row + 1, col];
            square[1, 1] = matrix[row + 1, col + 1]; 

            return square;
        }
        static int GetSquareSum(int[,] square)
        {
            int sum = 0;

            foreach (var element in square)
            {
                sum += element;
            }
            return sum;
        }
    }
}
