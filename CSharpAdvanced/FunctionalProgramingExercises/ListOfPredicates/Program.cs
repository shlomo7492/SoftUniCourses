using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                              .Select(int.Parse)
                              .ToArray();

            for (int i = 1; i <= num; i++)
            {
                bool truth = true;
                foreach (var n in dividers)
                {
                    if (i % n != 0)
                    {
                        truth = false;
                        break;
                    }
                }
                if((truth==true) && (i < num))
                {
                    Console.Write(i + " ");
                }
                else if(truth)
                {
                    Console.WriteLine(i);
                }
                
            }
        }


       
    }
}
