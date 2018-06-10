using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnTheRectBorder
{
    class PointOnTheBorder
    {
        static void Main(string[] args)
        {
            var xOne = float.Parse(Console.ReadLine());
            var yOne = float.Parse(Console.ReadLine());
            var xTwo = float.Parse(Console.ReadLine());
            var yTwo = float.Parse(Console.ReadLine());
            var x = float.Parse(Console.ReadLine());
            var y = float.Parse(Console.ReadLine());

            if (((x > xOne) && (x < xTwo) && (y > yOne) && (y < yTwo))||((x < xOne) || (x > xTwo) || (y < yOne) || (y > yTwo)))
            {
                Console.WriteLine("Inside / Outside");
            }
            else if ((((x == xOne) || (x == xTwo)) && ((y >= yOne) || (y <= yTwo)))||(((x >= xOne) || (x <= xTwo)) && ((y == yOne) || (y == yTwo))))
            {
                Console.WriteLine("Border");
            }
            Console.ReadKey();
        }
    }
}
