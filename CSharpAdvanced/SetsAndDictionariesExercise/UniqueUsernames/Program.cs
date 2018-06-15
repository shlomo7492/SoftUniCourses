using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniqueUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());
            HashSet<string> userNames = new HashSet<string>();
            for (int i=1;i<=inputNum;i++)
            {
                string userName = Console.ReadLine();
                if(!userNames.Contains(userName))
                {
                    userNames.Add(userName);
                }
            }
            foreach (string name in userNames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
