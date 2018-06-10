using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingFourNumbers
{
    class IncreasingFourNumbers
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            if ((first >= 2) && (first <= 1000) && (second >= 2) && (second <= 1000))
            {
                var n = second - first + 1;
                int[] myArray = new int[n];
                for (int i = 0; i < n; i++)
                {
                    myArray[i] = first + i;
                }
               
                if ((second - first) >= 3)
                {
                    for (int i = 0; i <= n-4; i++)
                    {
                       // currLine = currLine + " " + myArray[i];
                        for (int j = i+1; j <= n - 3; j++)
                        {
                            if (myArray[i] < myArray[j])
                            {
                                //currLine = currLine + " " + myArray[j];
                            
                                for (int k = j+1; k <= n - 2; k++)
                                {
                                    if (myArray[j] < myArray[k])
                                    {
                                        //currLine = currLine + " " + myArray[k];
                                    
                                        for (int m = k+1; m <= n - 1; m++)
                                        {
                                            if (myArray[k] < myArray[m])
                                            {
                                                Console.WriteLine(myArray[i]+" "+myArray[j]+" "+myArray[k] +" " + myArray[m]);
                                            }
                                    
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                else
                {
                    Console.WriteLine("No");
                }   
            }

            Console.ReadKey();

        }
    }
}
