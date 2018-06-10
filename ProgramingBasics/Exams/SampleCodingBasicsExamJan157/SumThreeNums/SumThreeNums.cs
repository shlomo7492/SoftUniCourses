using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumThreeNums
{
    class SumThreeNums
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());
            if ((a >= 1) && (a <= 1000) && (b >= 1) && (b <= 1000) && (c >= 1) && (c <= 1000))
            {
                if ((a + b) == c)
                {
                    if (a < b)
                    {
                        Console.WriteLine("{0} + {1} = {2}", a, b, c);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2}", b, a, c);
                    }
                }
                else if ((a + c) == b)
                {
                    if (a < c)
                    {
                        Console.WriteLine("{0} + {1} = {2}", a, c, b);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2}", c, a, b);
                    }
                }
                else if ((b + c) == a)
                {
                    if (b < c)
                    {
                        Console.WriteLine("{0} + {1} = {2}", b, c, a);
                    }
                    else
                    {
                        Console.WriteLine("{0} + {1} = {2}", c, b, a);
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
