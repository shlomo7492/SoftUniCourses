using System;
using System.Collections.Generic;
using System.Linq;

namespace UsersLogs
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Dictionary<string, int>> userLogs =
                                                new SortedDictionary<string, Dictionary<string, int>>();

            while(true)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if(input[0].ToLower()=="end")
                {
                    break;
                }

                input[2] = input[2].Substring(5, input[2].Length - 5);
                input[0] = input[0].Substring(3, input[0].Length - 3);


                if(userLogs.ContainsKey(input[2]))
                {
                    if(userLogs[input[2]].ContainsKey(input[0]))
                    {
                        userLogs[input[2]][input[0]]++;
                    }
                    else
                    {
                        userLogs[input[2]].Add(input[0], 1);
                    }
                }
                else
                {
                    userLogs.Add(input[2]
                                 , new Dictionary<string, int>() { [input[0]] = 1 });
                }
            }
            foreach (var user in userLogs)
            {
                Console.WriteLine($"{user.Key}: ");
                foreach (var ipCount in user.Value)
                {
                    if (!ipCount.Equals(user.Value.Last()))
                    {
                        Console.Write($" {ipCount.Key} => {ipCount.Value},");
                    }
                    else
                    {
                        Console.Write($" {ipCount.Key} => {ipCount.Value}.\n");
                    }
                }
                
            }
        }
    }
}
