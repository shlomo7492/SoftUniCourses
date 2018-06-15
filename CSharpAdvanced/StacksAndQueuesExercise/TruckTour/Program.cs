using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumpsNum = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();
            long tank = 0;
            int start = 0;
            for (int i = 0; i < pumpsNum; i++)
            {
                pumps.Enqueue(Console.ReadLine()
                            .Split(new char[] { ' ' }
                                   , StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToArray());
            }
            int count;

            for (int i=0;i<pumpsNum;i++)
            {
                start = i; //keeps the  index of the current starting pump.
                count = 0; //Keeps the number of trips between the pumps.Sets to 0 if travel not success
                while ((((pumps.Peek()[0] + tank) >= pumps.Peek()[1])) 
                        && (count < pumpsNum))
                {
                    count++;//increase on each step
                    tank += pumps.Peek()[0] - pumps.Peek()[1];//update fuel in the tank 

                    pumps.Enqueue(pumps.Dequeue()); 
                    //if the current pump(currently first in the queue) is passed 
                    //moves this pump in the end of the queue

                    i++; //if succesfull trip to next pump increase iteration variable
                    //skiping the passed pumps in case the whole jurney wasn't success
                    //and then the next search starts from next index
               }
                if (count == pumpsNum) 
                {
                    Console.WriteLine(start);
                    break;
                }
                else
                {
                    pumps.Enqueue(pumps.Dequeue());//moving the pump from which we can't trip
                    tank = 0;
                }               
            }
        }
    }
}
