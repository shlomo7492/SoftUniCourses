using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvatarNations
{
    class StartUp
    {
        static void Main(string[] args)
        {
            NationsBuilder nationBuilder = new NationsBuilder();
            while (true)
            {
                List<string> input = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "Quit")
                {
                    break;
                }
                switch (input[0])
                {
                    case "Bender":
                        {
                            nationBuilder.AssignBender(input.Skip(1).ToList());
                        }
                        break;
                    case "Monument":
                        {
                            nationBuilder.AssignMonument(input.Skip(1).ToList());
                        }
                        break;
                    case "Status":
                        {
                            Console.WriteLine(nationBuilder.GetStatus(input[1]));
                        }
                        break;
                    case "War":
                        {
                            nationBuilder.IssueWar(input[1]);
                        }
                        break;
                    default:break;
                }

            }
            Console.WriteLine(nationBuilder.GetWarsRecord());           
        }
    }
}
