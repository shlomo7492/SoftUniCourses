using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeComission
{
    class TradeComission
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            decimal profit = decimal.Parse(Console.ReadLine());
            decimal award = 0m;
            if (town=="Sofia")
            {
                if ((profit>=0)&&(profit<=500))
                {
                    award=(profit*5m)/100m;
                    Console.WriteLine("{0:f2}", award);
                }
                else if ((profit > 500) && (profit <= 1000))
                {
                    award = (profit * 7m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                } 
                else if ((profit > 1000) && (profit <= 10000))
                {
                    award = (profit * 8m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                } 
                else if (profit > 10000)
                {
                    award = (profit * 12m) / 100m;
                    Console.WriteLine("{0:f2}",award);

                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Varna")
            {
                if ((profit >= 0) && (profit <= 500))
                {
                    award = (profit * 4.5m) / 100m;
                    Console.WriteLine("{0:f2}", award);
                }
                else if ((profit > 500) && (profit <= 1000))
                {
                    award = (profit * 7.5m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                }
                else if ((profit > 1000) && (profit <= 10000))
                {
                    award = (profit * 10m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                }
                else if (profit > 10000)
                {
                    award = (profit * 13m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if ((profit >= 0) && (profit <= 500))
                {
                    award = (profit * 5.5m) / 100m;
                    Console.WriteLine("{0:f2}", award);
                }
                else if ((profit > 500) && (profit <= 1000))
                {
                    award = (profit * 8m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                }
                else if ((profit > 1000) && (profit <= 10000))
                {
                    award = (profit * 12m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                }
                else if (profit > 10000)
                {
                    award = (profit * 14.5m) / 100m;
                    Console.WriteLine("{0:f2}", award);

                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
