using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputStr = Console.ReadLine();
            SortedSet<string> parking = new SortedSet<string>();
            while (inputStr != "END")
            {
                var inputParams = Regex.Split(inputStr, ", ");
                if (inputParams[0] == "IN")
                    parking.Add(inputParams[1]);
                else
                    parking.Remove(inputParams[1]);
                inputStr = Console.ReadLine();
            }
            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
