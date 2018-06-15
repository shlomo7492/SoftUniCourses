using System;
using System.Linq;

namespace MaximalSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nm = Console.ReadLine()
                              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();
            int[,] matrix = new int[nm[0], nm[1]];

            int[,] maxSquare = new int[3, 3];
            int maxSum = 0;
            for (int row = 0; row < nm[0]; row++)
            {
                int[] inputLine = Console.ReadLine()
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToArray();
                for (int col = 0; col < nm[1]; col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }
            for (int row = 0; row < nm[0]-2; row++)
            {
                for (int col = 0; col < nm[1]-2; col++)
                {
                    if(GetSum(GetSquare(row,col,matrix))>GetSum(maxSquare))
                    {
                        maxSquare = GetSquare(row, col, matrix);
                        maxSum = GetSum(GetSquare(row, col, matrix));
                    }
                }
            }
            Console.WriteLine("Sum = " + maxSum);
            PrintSquare(maxSquare);
        }
        static int[,] GetSquare(int row, int col, int[,] matrix)
        {
            int[,] square = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    square[i, j] = matrix[row + i, col + j];
                }
            }

            return square;
        }
        static int GetSum(int[,] square)
        {
            int sum = 0;
            foreach (int element in square)
            {
                sum += element;
            }
            return sum;
        }
        static void PrintSquare(int[,] square)
        {
            for(int i=0;i<square.GetLength(0);i++)
            {
                for (int j = 0; j < square.GetLength(0); j++)
                {
                    Console.Write(square[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
