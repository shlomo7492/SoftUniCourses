using System;
using System.Collections.Generic;

namespace AMinersTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource =="stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                
                if(resources.ContainsKey(resource))
                {
                    resources[resource] += quantity;
                }
                else
                {
                    resources.Add(resource, quantity);
                }
            }
            foreach (KeyValuePair<string, int> res in resources)
            {
                Console.WriteLine($"{res.Key} -> {res.Value}");
            }
        }
    }
}
