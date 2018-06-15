using System;
using System.Collections.Generic;
using System.Linq;

namespace PopulationCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> countries = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string,int>> countryCities = 
                                                    new Dictionary<string,Dictionary < string,int>> ();
            while(true)
            {
                string[] input = Console.ReadLine()
                    .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                if (input[0]=="report")
                {
                    break;
                }
                if(countries.ContainsKey(input[1]))
                {
                    countries[input[1]] += int.Parse(input[2]);
                    countryCities[input[1]].Add(input[0], int.Parse(input[2]));   
                }
                else
                {
                    countries.Add(input[1], int.Parse(input[2]));
                    countryCities.Add(input[1], new Dictionary<string, int>() { [input[0]] = int.Parse(input[2]) });
                }
            }
            foreach (var country in countries.OrderByDescending(ctry => ctry.Value))
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");

                foreach (var cities in countryCities
                                     .Where(x => x.Key == country.Key)
                                     .ToDictionary(x=>x).Values)
                {
                    foreach (var city in cities.Value.OrderByDescending(x=>x.Value))
                    {
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    }
                }
            }
        }
    }
}
