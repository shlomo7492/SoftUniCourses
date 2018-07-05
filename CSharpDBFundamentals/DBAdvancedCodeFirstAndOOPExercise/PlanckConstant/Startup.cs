using Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanckConstant
{
    class Startup
    {
        static void Main(string[] args)
        {
            Calculation calc = new Calculation();
            Console.WriteLine(Calculation.GetRedusedPlanckConstant());
        }
    }
}
