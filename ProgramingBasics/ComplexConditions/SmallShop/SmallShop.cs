using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
    class SmallShop
    {
        public static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string town = Console.ReadLine();
            var quantity = float.Parse(Console.ReadLine());
            double total = 0;

            switch (town)
            {
                case "Sofia":
                    switch (item)
                    {
                        case "coffee":
                            total = quantity * 0.5;
                            break;
                        case "water":
                            total = quantity * 0.8;
                            break;
                        case "beer":
                            total = quantity * 1.2;
                            break;
                        case "sweets":
                            total = quantity * 1.45;
                            break;
                        case "peanuts":
                            total = quantity * 1.6;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Plovdiv":
                    switch (item)
                    {
                        case "coffee":
                            total = quantity * 0.40;
                            break;
                        case "water":
                            total = quantity * 0.7;
                            break;
                        case "beer":
                            total = quantity * 1.15;
                            break;
                        case "sweets":
                            total = quantity * 1.3;
                            break;
                        case "peanuts":
                            total = quantity * 1.5;
                            break;
                        default:
                            break;
                    }
                    break;
                case "Varna":
                    switch (item)
                    {
                        case "coffee":
                            total = quantity * 0.45;
                            break;
                        case "water":
                            total = quantity * 0.7;
                            break;
                        case "beer":
                            total = quantity * 1.1;
                            break;
                        case "sweets":
                            total = quantity * 1.35;
                            break;
                        case "peanuts":
                            total = quantity * 1.55;
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine(total);
        }
    }
}
