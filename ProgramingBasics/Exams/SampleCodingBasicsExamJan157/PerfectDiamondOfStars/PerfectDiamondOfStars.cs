using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectDiamondOfStars
{
    class PerfectDiamondOfStars
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if ((n != 1)&&(n>=1)&&(n<=1000))
            {
                Console.WriteLine((new string(' ', n - 1)) + "*");
                for (int loop = 1; loop <= 2; loop++)
                {
                    string inner = "";

                    if (loop == 1)
                    {
                        for (int i = 2; i <= n; i++)
                        {
                            inner = inner + "*-";
                            Console.WriteLine((new string(' ', n - i)) + inner + "*");
                        }
                    }
                    else
                    {
                        for (int i = 1; i <= n - 2; i++)
                        {
                            for (int j = 1; j <= n - (i + 1); j++)
                            {
                                inner = inner + "*-";
                            }
                            Console.WriteLine((new string(' ', (n - (n - i)))) + inner + "*");
                            inner = "";
                        }
                    }
                }
             }   
            Console.WriteLine((new string(' ', n - 1)) + "*");
            
            Console.ReadKey();
        }
    }
}
