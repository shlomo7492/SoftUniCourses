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
            int cycle = 1;
            while (kids.Count > 1)
            {
                var lim = kids.Count;
                if (loops % kids.Count == 0)
                {

                    for (int i = 0; i < lim - 1; i++)
                    {
                        kids.Enqueue(kids.Dequeue());
                    }
                    if (IsPrime(cycle))
                    {
                        Console.WriteLine("Prime " + kids.Peek());
                    }
                    else
                    {
                        Console.WriteLine("Removed " + kids.Dequeue());
                    }
                }
                else
                {
                    if (loops % kids.Count == 1)
                    {
                        if (IsPrime(cycle))
                        {
                            Console.WriteLine("Prime " + kids.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Removed " + kids.Dequeue());
                        }
                    }
                    else
                    {
                        lim = loops % kids.Count - 1;
                        for (int i = 0; i < lim; i++)
                        {
                            kids.Enqueue(kids.Dequeue());
                        }
                        if (IsPrime(cycle))
                        {
                            Console.WriteLine("Prime " + kids.Peek());
                        }
                        else
                        {
                            Console.WriteLine("Removed " + kids.Dequeue());
                        }
                    }
                }
                cycle++;
            }
            Console.WriteLine("Last is " + kids.Dequeue());

        }
        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        } 
    }
}
