using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minedraft
{
    class Program
    {
        static void Main(string[] args)
        {
            DraftManager draft = new DraftManager();
            while (true)
            {
                List<string> arguments = Console.ReadLine()
                                                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();
                if (arguments[0] == "Shutdown")
                {
                    break;
                }
                switch (arguments[0])
                {
                    case "RegisterHarvester":
                        {
                            Console.WriteLine(draft.RegisterHarvester(arguments));
                        }
                        break;
                    case "RegisterProvider":
                        {
                            Console.WriteLine(draft.RegisterProvider(arguments));
                        }
                        break;
                    case "Day":
                        {
                            Console.WriteLine(draft.Day());
                        }
                        break;
                    case "Mode":
                        {
                            Console.WriteLine(draft.Mode(arguments));
                        }
                        break;
                    case "Check":
                        {
                            Console.WriteLine(draft.Check(arguments));
                        }
                        break;
                    default:break;
                }

            }
            Console.WriteLine(draft.ShutDown());
        }

    }
}
