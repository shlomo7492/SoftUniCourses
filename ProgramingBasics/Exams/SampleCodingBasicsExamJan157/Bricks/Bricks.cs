using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bricks
{
    class Bricks
    {
        static void Main(string[] args)
        {
            var bricksNum = int.Parse(Console.ReadLine());
            var workersNum = int.Parse(Console.ReadLine());
            var workerLifts = int.Parse(Console.ReadLine());
            if ((bricksNum >= 1) && (bricksNum <= 1000) && (workersNum >= 1) && (workersNum <= 1000)&&(workerLifts >= 1) && (workerLifts <= 1000))
            { 
                if (bricksNum <= (workersNum*workerLifts))
                {
                    Console.WriteLine("1");
                }
                else
                {
                    Console.WriteLine(Math.Round((bricksNum / ((double)workersNum * (double)workerLifts)), 0));
                }
            }
            Console.ReadKey();
        }
    }
}
