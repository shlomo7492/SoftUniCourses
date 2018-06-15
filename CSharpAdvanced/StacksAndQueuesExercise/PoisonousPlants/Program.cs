using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoisonousPlants
{
    class Program
    {
        private static Queue<int> plants;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            plants = new Queue<int>();
            foreach (int plant in Console.ReadLine()
                                        .Split(' ')
                                        .Select(int.Parse)
                                        .ToArray())
            {
                plants.Enqueue(plant);
            }
            int day = 0;
            while (day>=0)
            {
                int lim = plants.Count;
                Stack<int> deadPlants = new Stack<int>();
                int current = plants.Dequeue();
                for(int i=2;i<=lim;i++)
                {
                    if (current < plants.Peek())
                    {
                        
                        deadPlants.Push(i);
                    }
                    plants.Enqueue(current);
                    current = plants.Dequeue();
                }
                plants.Enqueue(current);
                if (deadPlants.Count > 0)
                {
                    day++;
                    lim = deadPlants.Count;
                    for(int i=1;i<=lim;i++)
                    {
                        RemovePlant(deadPlants.Pop());
                    }
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine(day);
        }
        static void RemovePlant(int n)
        {
            int lim = plants.Count;
            for (int i=1;i<=lim;i++)
            {
                if(i==n)
                {
                    plants.Dequeue();
                }
                else
                {
                    plants.Enqueue(plants.Dequeue());
                }
            }
        }
    }
}
