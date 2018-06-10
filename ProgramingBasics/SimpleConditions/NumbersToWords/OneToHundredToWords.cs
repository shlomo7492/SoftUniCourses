using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersToWords
{
    class OneToHundredToWords
    {
        static void Main(string[] args)
        {
            var number = Console.ReadLine();
            if ((number.Length == 3) && (number == "100"))
            {
                Console.WriteLine("one hundred");
            }
            else if ((number.Length == 3) && (int.Parse(number) > 100))
            {
                Console.WriteLine("invalid number");
            }
            else if (number.Length == 2)
            {
                if (int.Parse(number) < 0)
                {
                    Console.WriteLine("invalid number");
                }
                else
                {
                    switch (number[0])
                    {

                        case '1':
                            //Console.WriteLine("I am here");
                            switch (number[1])
                            {
                                case '0':
                                    Console.WriteLine("ten"); break;
                                case '1':
                                    Console.WriteLine("eleven"); break;
                                case '2':
                                    Console.WriteLine("twelve"); break;
                                case '3':
                                    Console.WriteLine("thirteen"); break;
                                case '4':
                                    Console.WriteLine("fourteen"); break;
                                case '5':
                                    Console.WriteLine("fifteen"); break;
                                case '6':
                                    Console.WriteLine("sixteen"); break;
                                case '7':
                                    Console.WriteLine("seventeen"); break;
                                case '8':
                                    Console.WriteLine("eighteen"); break;
                                case '9':
                                    Console.WriteLine("nineteen"); break;
                                default: break;
                            } break;
                        case '2':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("twenty");
                            }
                            else
                            {
                                Console.WriteLine("twenty " + NumberName(number[1]));
                            } break;
                        case '3':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("thirty");
                            }
                            else
                            {
                                Console.WriteLine("thirty " + NumberName(number[1]));
                            } break;
                        case '4':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("fourty");
                            }
                            else
                            {
                                Console.WriteLine("fourty " + NumberName(number[1]));
                            } break;
                        case '5':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("fifty");
                            }
                            else
                            {
                                Console.WriteLine("fifty " + NumberName(number[1]));
                            } break;
                        case '6':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("sixty");
                            }
                            else
                            {
                                Console.WriteLine("sixty " + NumberName(number[1]));
                            } break;
                        case '7':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("seventy");
                            }
                            else
                            {
                                Console.WriteLine("seventy " + NumberName(number[1]));
                            } break;
                        case '8':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("eighty");
                            }
                            else
                            {
                                Console.WriteLine("eighty " + NumberName(number[1]));
                            } break;
                        case '9':
                            if (number[1] == '0')
                            {
                                Console.WriteLine("ninety");
                            }
                            else
                            {
                                Console.WriteLine("ninety " + NumberName(number[1]));
                            } break;
                        default: break;


                    }
                }
            }
            else if (number.Length == 1)
            {
                Console.WriteLine(NumberName(number[0]));
            }
            else
            {
                Console.WriteLine("invalid number");
            }
            Console.ReadKey();
        }
        public static string NumberName(char digit)
        {
            string number = "";
            switch (digit)
            {
                case '0':
                    number ="zero"; break;
                case '1':
                    number ="one"; break;
                case '2':
                    number ="two"; break;
                case '3':
                    number ="three"; break;
                case '4':
                    number ="four"; break;
                case '5':
                    number ="five"; break;
                case '6':
                    number ="six"; break;
                case '7':
                    number ="seven"; break;
                case '8':
                    number ="eight"; break;
                case '9':
                    number ="nine"; break;
                default: break;
            }
            return number;
        }
    }
}
