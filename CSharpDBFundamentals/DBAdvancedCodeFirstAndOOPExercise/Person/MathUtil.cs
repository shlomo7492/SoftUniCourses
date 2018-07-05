using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class MathUtil
    {
        private double firstNum;
        private double secondNum;

        public double FirstNum { get; set; }
        public double SecondNum { get; set; }

        public static double Sum(double firstNum, double secondNum)
        {
            return firstNum + secondNum;
        }
        public static double Subtract(double firstNum, double secondNum)
        {
            return firstNum - secondNum;
        }
        public static double Multiply(double firstNum, double secondNum)
        {
            return firstNum * secondNum;
        }
        public static double Divide(double firstNum, double secondNum)
        {
            return firstNum / secondNum;
        }
        public static double Percentage(double firstNum, double secondNum)
        {
            return Multiply(firstNum, Divide(secondNum,100.00));
        }
    }
}
