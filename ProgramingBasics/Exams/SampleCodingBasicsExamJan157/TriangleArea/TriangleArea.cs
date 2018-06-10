using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleArea
{
    class TriangleArea
    {
        static void Main(string[] args)
        {
            var xOne = int.Parse(Console.ReadLine());
            var yOne = int.Parse(Console.ReadLine());
            var xTwo = int.Parse(Console.ReadLine());
            var yTwo = int.Parse(Console.ReadLine());
            var xThree = int.Parse(Console.ReadLine());
            var yThree = int.Parse(Console.ReadLine());
            var area = Math.Abs(xTwo-xThree)*Math.Abs(yTwo - yOne) / 2.0;
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
