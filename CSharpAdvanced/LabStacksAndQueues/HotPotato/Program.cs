using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int loops = int.Parse(Console.ReadLine());

            Queue<string> kids = new Queue<string>();

            foreach (string name in names)
            {
                kids.Enqueue(name);
            }
            while (kids.Count > 1)
            {
                var lim = kids.Count;
                if (loops % kids.Count == 0)
                {
                    
                    for (int i = 0; i < lim-1; i++)
                    {
                        kids.Enqueue(kids.Dequeue());
                    }
                    Console.WriteLine("Removed " + kids.Dequeue());
                }
                else
                {
                    if(loops % kids.Count == 1)
                    {
                        Console.WriteLine("Removed " + kids.Dequeue());
                    }
                    else
                    {
                        lim = loops % kids.Count - 1;
                        for (int i = 0; i < lim; i++)
                        {
                            kids.Enqueue(kids.Dequeue());
                        }
                        Console.WriteLine("Removed "+kids.Dequeue());
                    }
                }
            }
            Console.WriteLine("Last is "+kids.Dequeue());

        }
    }
}
