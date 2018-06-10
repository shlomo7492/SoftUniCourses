using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string movieType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());
            if (movieType == "Premiere")
            {
                Console.WriteLine("{0:f2} leva", (12.00m * (decimal)(rows * cols)));
            }
            else if (movieType == "Normal")
            {
                Console.WriteLine("{0:f2} leva", (7.50m * (decimal)(rows * cols)));
            }
            else if (movieType == "Discount")
            {
                Console.WriteLine("{0:f2} leva", (5.00m * (decimal)(rows * cols)));
            }
        }
    }
}
