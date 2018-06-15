using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console.ReadLine()
                                         .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Select(int.Parse)
                                         .ToArray();
            char[,] matrix = new char[rowsCols[0], rowsCols[1]];
            int countSquares = 0;
            for (int row = 0; row < rowsCols[0]; row++)
            {
                string inputLine = String.Join("",Console.ReadLine().Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                for (int col = 0; col < rowsCols[1]; col++)
                {
                    matrix[row, col] = inputLine[col];
                }
            }
            for(int row=0;row<rowsCols[0]-1; row++)
            {
                for (int col = 0; col < rowsCols[1]-1; col++)
                {
                    if (IsSquare(row, col, matrix) == true)
                    {
                        countSquares++;
                    }
                }
            }
            Console.WriteLine(countSquares);
        }
        static bool IsSquare(int row,int col,char[,] matrix)
        {
            if(matrix[row,col]==matrix[row,col+1]
                && matrix[row, col] == matrix[row+1,col]
                && matrix[row, col] == matrix[row + 1, col + 1])
            {
                return true;
            }
            return false;
        }
    }
}
