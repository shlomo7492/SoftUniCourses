using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Calculation
    {
        public static double planckConstant = 6.62606896e-34;
        public static double pI = 3.14159;
        public static double GetRedusedPlanckConstant()
        {
            return planckConstant / (2 * pI);
        }
    }
}
