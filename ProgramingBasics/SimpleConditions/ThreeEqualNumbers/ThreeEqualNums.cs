using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeEqualNumbers
{
    class ThreeEqualNums
    {
        static void Main(string[] args)
        {
            var numOne = int.Parse(Console.ReadLine());
            var numTwo = int.Parse(Console.ReadLine());
            var numThree = int.Parse(Console.ReadLine());

            if ((numOne == numTwo) && (numTwo == numThree))
            {
                Console.WriteLine("yes");
            }
            else 
            {
                Console.WriteLine("no");
            }
        }
    }
}
