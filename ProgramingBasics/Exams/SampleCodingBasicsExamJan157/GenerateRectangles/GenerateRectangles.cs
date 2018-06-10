using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateRectangles
{
    class GenerateRectangles
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minArea = int.Parse(Console.ReadLine());

           for (int xOne = -n; xOne <= n; xOne++)
           {
                for (int yOne = -n; yOne <= n; yOne++)
                {
                    for (int xTwo = xOne+1; xTwo <= n; xTwo++)
                    {
                        for (int yTwo = yOne+1; yTwo <= n; yTwo++)
                        {
                            if (((Math.Abs(xOne - xTwo)) * (Math.Abs(yOne - yTwo))) >= minArea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", xOne, yOne, xTwo, yTwo, ((Math.Abs(xOne - xTwo)) * (Math.Abs(yOne - yTwo))));
                            }
                        }
                           
                    }
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
