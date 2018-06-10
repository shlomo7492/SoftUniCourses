using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
    class PointInFigure
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            if ((x >= -1000) && (x <= 1000) && (y >= -1000) && (y <= 1000))
            {
                if (((x >= 2) && (x < 4))||((x>10)&&(x<=12)))
                {
                    if ((y >= -3) && (y <= 1))
                    { 
                        Console.WriteLine("in");
                    }
                    else
                    {
                         Console.WriteLine("out");
                    }
                
                }
                else if ((x>=4)&&(x<=10))
                {
                    if ((y >= -5)&&(y <= 3))
                    {
                        Console.WriteLine("in");

                    }
                    else
                    {
                         Console.WriteLine("out");
                    }
                }
                else
                {
                     Console.WriteLine("out");

                }
            }
            Console.ReadKey();
        }
    }
}
