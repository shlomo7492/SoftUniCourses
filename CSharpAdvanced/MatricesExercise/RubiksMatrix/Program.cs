using System;
using System.Linq;

namespace RubiksMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();
            int row = input[0];
            int col = input[1];
            int[][] matrix = GetRubikMatrix(row, col);
            int n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                string[] command = Console.ReadLine()
                                           .Split(new char[] { ' ' }
                                           , StringSplitOptions.RemoveEmptyEntries);
                switch (command[1])
                {
                    case "up":
                    case "down":
                        {
                           matrix = MoveVertical(command,matrix);
                        }
                        break;
                    case "left":
                    case "right":
                        {
                            matrix = MoveHorizontal(command,matrix);
                        }
                        break;
                    default:break;
                }
            }
            RearrangeMatrix(row,col,matrix);
        }
        static int[][] GetRubikMatrix(int row,int col)
        {
            int[][] matrix = new int[row][];
            for(int i = 0; i < row; i++)
            {
                matrix[i] = new int[col];
            }
            for (int i=0;i<row;i++)
            {
                for (int j = 0; j < col; j++)
                {
                    matrix[i][j]= i * col + (j + 1);
                }
            }
            return matrix;
        }
        static int[][] MoveVertical(string[] command,int[][] matrix)
        {
            int tempValue = 0;
            int col = int.Parse(command[0]);
            int times = int.Parse(command[2]);
            if (command[1] == "down")
            {
                for (int i = 0; i < times; i++)
                {
                    tempValue = matrix[matrix.GetLength(0) - 1][col];
                    for (int k = matrix.GetLength(0) - 1; k >= 1; k--)
                    {
                        matrix[k][col] = matrix[k - 1][col];
                    }
                    matrix[0][col] = tempValue;
                }
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    tempValue = matrix[0][col];
                    for (int k = 0; k < matrix.GetLength(0) - 1; k++)
                    {
                        matrix[k][col] = matrix[k + 1][col];
                    }
                    matrix[matrix.GetLength(0) - 1][col] = tempValue;
                }
            }
            return matrix;
        }
        static int[][] MoveHorizontal(string[] command,int[][] matrix)
        {
            int tempValue = 0;
            int row = int.Parse(command[0]);
            int times = int.Parse(command[2]);
            if (command[1] == "right")
            {
                for (int i=0;i<times;i++)
                {
                    tempValue = matrix[row][matrix[row].Length - 1];
                    for(int k=matrix[row].Length;k>=1;k--)
                    {
                        matrix[row][k] = matrix[row][k - 1];
                    }
                    matrix[row][0] = tempValue;
                }
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    tempValue = matrix[row][0];
                    for (int k = 0; k < matrix[row].Length - 1; k++)
                    {
                        matrix[row][k] = matrix[row][k + 1];
                    }
                    matrix[row][matrix[row].Length - 1] = tempValue;
                }
            }
            return matrix;    
        }
        static void RearrangeMatrix(int rows, int cols,int[][] matrix)
        {
            int cellValue = 0;
            int currentValue = 0;
            for(int row = 0; row < rows; row++)
            {
                for(int col=0;col<cols;col++)
                {
                    currentValue = matrix[row][col];
                    cellValue = row * cols + (col + 1);
                    if(cellValue!=currentValue)
                    {
                        for(int k = 0; k < rows; k++)
                        {
                            var thisRow = matrix[k];
                            int index = Array.IndexOf(thisRow, cellValue);
                            if(index>-1)
                            {
                                matrix[row][col] = cellValue;
                                matrix[k][index] = currentValue;
                                Console.WriteLine($"Swap ({row}, {col}) with ({k}, {index})");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No swap required");
                    }
                }
            }
        }
    }
}
