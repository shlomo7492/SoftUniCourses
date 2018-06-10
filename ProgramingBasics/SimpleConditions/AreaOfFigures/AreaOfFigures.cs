using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            var figureType = Console.ReadLine();
            if (figureType == "square")
            {
                var aBase = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", aBase * aBase);
            }
            else if (figureType == "rectangle")
            {
                var aBase = double.Parse(Console.ReadLine());
                var bBase = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", aBase * bBase);
            }
            else if (figureType == "circle")
            {
                var radius = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}", radius * radius * Math.PI);
            }
            else 
            {
                var aBase = double.Parse(Console.ReadLine());
                var height = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:f3}",(aBase * height)/2);
            }
        }
    }
}
