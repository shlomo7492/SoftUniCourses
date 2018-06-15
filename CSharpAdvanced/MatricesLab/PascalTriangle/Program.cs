using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i=0;i<n;i++)
            {
                matrix[i] = new int[i + 1];
                matrix[i][0] = 1;
                matrix[i][i] = 1;

            }

            for (int i=2;i<n;i++)
            {

                for (int j = 1; j <= i-1; j++)
                {
                     matrix[i][j] = matrix[i - 1][j - 1] + matrix[i - 1][j];                    
                }
            }
            for (int i = 0; i < n; i++)
            {
                foreach (var item in matrix[i])

                {
                    Console.Write(item + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
