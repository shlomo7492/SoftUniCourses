using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitShop
{
    class FruitShop
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());
            bool invalid = true;
            decimal price = 0m;
            string[] days = new string[]{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
            string[] weekend = new string[] { "Saturday", "Sunday" };

            foreach (string element in days)
            {
                if (element == day)
                {
                    switch (fruit)
                    {
                        case "banana":
                            {
                                price = quantity * 2.50m;
                                invalid = false;
                            } break;
                        case "apple":
                            {
                                price = quantity * 1.20m;
                                invalid = false;
                            } break;
                        case "orange":
                            {
                                price = quantity * 0.85m;
                                invalid = false;
                            } break;
                        case "grapefruit":
                            {
                                price = quantity * 1.45m;
                                invalid = false;
                            } break;
                        case "kiwi":
                            {
                                price = quantity * 2.70m;
                                invalid = false;
                            } break;
                        case "pineapple":
                            {
                                price = quantity * 5.50m;
                                invalid = false;
                            } break;
                        case "grapes":
                            {
                                price = quantity * 3.85m;
                                invalid = false;
                            } break;
                        default: break;
                    }
                }
                else
                {
                    foreach (string entry in weekend)
                    {
                        if (day == entry)
                        {
                            switch (fruit)
                            {
                                case "banana":
                                    {
                                        price = quantity * 2.70m;
                                        invalid = false;
                                    } break;
                                case "apple":
                                    {
                                        price = quantity * 1.25m;
                                        invalid = false;
                                    } break;
                                case "orange":
                                    {
                                        price = quantity * 0.90m;
                                        invalid = false;
                                    } break;
                                case "grapefruit":
                                    {
                                        price = quantity * 1.60m;
                                        invalid = false;
                                    } break;
                                case "kiwi":
                                    {
                                        price = quantity * 3.00m;
                                        invalid = false;
                                    } break;
                                case "pineapple":
                                    {
                                        price = quantity * 5.60m;
                                        invalid = false;
                                    } break;
                                case "grapes":
                                    {
                                        price = quantity * 4.20m;
                                        invalid = false;
                                    } break;
                                default: break;
                            }
                        }
                    }
                }
            }
            if (invalid)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine("{0:f2}", price);
            }
            Console.ReadKey();
        }
    }
}
