using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[0-9]+ [A-z]+";
            Dictionary<string, int> keyResources = new Dictionary<string, int>()
            {
                ["shards"] = 0,
                ["fragments"] = 0,
                ["motes"] = 0
            };
            Dictionary<string, string> legendaryItem = new Dictionary<string, string>()
            {
                ["shards"] = "Shadowmourne ",
                ["motes"] = "Dragonwrath",
                ["fragments"] = "Valanyr"
            };
            Dictionary<string, int> junk = new Dictionary<string, int>();
            string result = "";
            byte step = 0;
            while(true)
            {
                step++;
                string input = Console.ReadLine();
                foreach(Match res in Regex.Matches(input,pattern))
                {
                    string[] resource = res.ToString()
                                           .ToLower()
                                           .Split(new char[] { ' ' }
                                           ,StringSplitOptions.RemoveEmptyEntries);
                    if(keyResources.ContainsKey(resource[1]))
                    {
                        keyResources[resource[1]] += int.Parse(resource[0]);
                        if (keyResources[resource[1]] >= 250 && result == "")
                        {
                            result = resource[1];
                            keyResources[resource[1]] -= 250;
                            break;
                        }
                    }
                    else
                    {
                        if(junk.ContainsKey(resource[1]))
                        {
                            junk[resource[1]] += int.Parse(resource[0]);
                        }
                        else
                        {
                            junk.Add(resource[1], int.Parse(resource[0]));
                        }
                    }
                }
                if ((result!="")|| (step >= 10)) break;
            }
            Console.WriteLine($"{legendaryItem[result]} obtained!");
            foreach (var keyResource in keyResources.OrderByDescending(x=>x.Value)
                                                    .ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{keyResource.Key}: {keyResource.Value}");
            }
            foreach (var junky in junk.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{junky.Key}: {junky.Value}");

            }
        }
    }
}
