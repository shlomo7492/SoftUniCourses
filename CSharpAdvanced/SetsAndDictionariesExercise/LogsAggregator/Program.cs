using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            SortedDictionary<string, int> userDuration = new SortedDictionary<string, int>();
            SortedDictionary<string, List<string>> userIpAddresses = new SortedDictionary<string, List<string>>();
            
            for (int i=1;i<=n;i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(userDuration.ContainsKey(input[1]))
                {
                    userDuration[input[1]] += int.Parse(input[2]);
                    userIpAddresses[input[1]].Add(input[0]);
                }
                else
                {
                    userDuration.Add(input[1], int.Parse(input[2]));
                    userIpAddresses.Add(input[1], new List<string>(){input[0]});
                }
            }
            foreach(var user in userDuration)
            {
                Console.Write($"{user.Key}: {user.Value} [");
                List<string> ipAddresses = userIpAddresses.Where(yx => yx.Key == user.Key)
                                                          .Select(x=>x.Value)
                                                          .SingleOrDefault()
                                                          .ToList();
                ipAddresses = ipAddresses.Distinct().OrderBy(x => x).ToList();                              
                foreach (var userIp in ipAddresses)
                {
                    if (userIp != ipAddresses.Last())
                    {
                        Console.Write($"{userIp}, ");
                    }
                    else
                    {
                        Console.Write($"{userIp}]");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
