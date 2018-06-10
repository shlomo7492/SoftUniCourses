using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInTheFigure
{
    class PointInTheFigure
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            if (((x > 0) && (x < (3 * h)) && (y > 0) && (y < h)) || ((x > h) && (x < (2 * h)) && (((y > h) && (y < 4 * h)) || (y == h))))
            {
                Console.WriteLine("inside");
            }
            else if ((y < 0) || (y > 4 * h) || ((y > h) && ((x < h) || (x > 2 * h))) || (x > 3 * h)|| (x < 0))
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
            Console.ReadKey();
        }
    }

}