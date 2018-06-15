using System;
using System.Collections.Generic;
using System.Linq;

namespace HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cardsValues = new Dictionary<string, int>()
            {
                ["2"]=2,
                ["3"] = 3,
                ["4"] = 4,
                ["5"] = 5,
                ["6"] = 6,
                ["7"] = 7,
                ["8"] = 8,
                ["9"] = 9,
                ["10"] = 10,
                ["J"] = 11,
                ["Q"] = 12,
                ["K"] = 13,
                ["A"] = 14
            };
            Dictionary<char, int> multiplyers = new Dictionary<char, int>()
            {
                ['S'] = 4,
                ['H'] = 3,
                ['D'] = 2,
                ['C'] = 1
            };
            Dictionary<string, List<string>> playerScore = new Dictionary<string, List<string>>();
            while(true)
            {
                string[] input = Console.ReadLine()
                       .Split(new char[] { ' ',',',':' }, StringSplitOptions
                                                        .RemoveEmptyEntries)
                                                        .Distinct()
                                                        .ToArray();
                if(input[0]=="JOKER")
                {
                    break;
                }
                if (playerScore.ContainsKey(input[0]))
                {
                    for (int i = 1; i < input.Length; i++)
                    {
                        playerScore[input[0]].Add(input[i]);
                    }
                }
                else if(input.Length>1)
                {
                    playerScore.Add(input[0], new List<string>(){input[1]});
                    for (int i = 2; i < input.Length; i++)
                    {
                        playerScore[input[0]].Add(input[i]);
                    }
                }
            }
            foreach (KeyValuePair<string,List<string>> score in playerScore)
            {
                int totalscore = 0;
                foreach (string card in score.Value.Distinct())
                {
                    if (card.Length == 2)
                    {
                        totalscore += cardsValues[card[0] + ""] * multiplyers[card[1]];
                    }
                    else
                    {
                        totalscore += cardsValues[card[0] + "" + card[1]] * multiplyers[card[2]];
                    }
                }
                Console.WriteLine($"{score.Key}: {totalscore}");

            }
        }
    }
}
