using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOfPalindromes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            int[] dimenssions = Console.ReadLine()
                                       .Split(' ')
                                       .Select(int.Parse)
                                       .ToArray();
            string[,] matrix = new string[dimenssions[0],dimenssions[1]];
            for(int row=0;row<dimenssions[0];row++)
            {
                int symbol = 97+row;
                for(int col = 0; col < dimenssions[1]; col++)
                {
                    matrix[row, col] = "" + (char)(symbol) + (char)(symbol + col) + (char)(symbol);
                    if (col == (dimenssions[1] - 1))
                    {
                        Console.Write(matrix[row,col]);
                    }
                    else
                    {
                        Console.Write(matrix[row,col] + " ");
                    }
                }
                Console.WriteLine();
            }
          
        }
    }
}
