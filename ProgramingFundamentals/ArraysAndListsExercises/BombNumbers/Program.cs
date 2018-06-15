using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] bomb=Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bombSplashRadius = bomb[1];
            for (int i = 0; i < numberList.Count; i++)
            {
                if (numberList[i] == bomb[0])
                {

                    numberList = (numberList.Take(i - bombSplashRadius)).Concat(numberList.Skip(i + bombSplashRadius+1)
                                                                           .Take(numberList.Count - (i + bombSplashRadius))).ToList();
                }
            }
            Console.WriteLine("{0}", numberList.Sum());
        }
    }
}
