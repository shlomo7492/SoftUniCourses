using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNumber = int.Parse(Console.ReadLine());
            int secSelector = nNumber + 1;
            int thirdSelector = 2*nNumber + 1;

            for (int i = 1; i <= 3 * nNumber + 1; i++)
            {
                if (i <= nNumber)
                {
                    string wave="";
                    string dotsIncrease = "";
                    string dots="";
                    //Console.Write("#");
                    if ((i - 1) > 0)
                    {
                        for (int j = 1; j <= i - 1;j++ )
                        {
                            wave = wave + "~";
                            dotsIncrease = dotsIncrease + "..";
                        }
                    }
                    for (int j = 1; j <= (nNumber-(i-1)); j++)
                    {
                        dots = dots + "..";
                    }
                    Console.WriteLine ("#" + wave + "#" + dots + "#" + dotsIncrease + "#" + dots + "#" + wave + "#");

                }
                else if ((i >= (nNumber + 1))&&(i<(2*nNumber+2)))
                {
                    string wave = "";
                    string dotsIncrease = ".";
                    string dots = "";
                    if (i>secSelector)
                    {
                        for (int j = 1; j <= (i-secSelector); j++)
                        {
                            dotsIncrease = dotsIncrease + "..";
                        }
                    }
                    for (int j = 1; j <= (nNumber-(i-secSelector)); j++)
                    {
                        wave = wave + "~";
                        dots = dots + "..";
                    }
                    Console.WriteLine(dotsIncrease + "#" + wave + "#" + dots + "#" + wave + "#" + dotsIncrease);
                }
                else if (i >= (2 * nNumber + 2))
                {
                    string dots = "";
                    for (int j = 1; j <= secSelector; j++)
                    {
                        dots = dots + "..";
                    }
                    Console.WriteLine(dots + "##" + dots);
                }
            }
            Console.ReadKey();
        }
    }
}
