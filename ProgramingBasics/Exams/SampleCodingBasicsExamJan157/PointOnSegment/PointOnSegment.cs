using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnSegment
{
    class PointOnSegment
    {
        static void Main(string[] args)
        {
            var first = int.Parse(Console.ReadLine());
            var second = int.Parse(Console.ReadLine());
            var point = int.Parse(Console.ReadLine());
            if ((first > second)&&(point>=second)&&(point<=first))
            {
                    Console.WriteLine("in");
            }
            else if ((first < second) && (point <= second) && (point >= first))
            {
                Console.WriteLine("in");
            }
            else 
            {
                Console.WriteLine("out");
            }

            if (Math.Abs(first - point) > Math.Abs(second - point))
            {
                Console.WriteLine(Math.Abs(second - point));
            }
            else 
            {
                Console.WriteLine(Math.Abs(first - point));

            }
            Console.ReadKey();
        }
    }
}
