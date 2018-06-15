using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRasing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                Car car = new Car()
                {
                    Model = input[0],
                    FuelAmount = double.Parse(input[1]),
                    FuelPerKm =double.Parse(input[2])
                };
                if (cars.Where(c => c.Model == car.Model).SingleOrDefault() == null)
                {
                    cars.Add(car);
                }
            }
            while (true)
            {
                string[] command = Console.ReadLine().Split(' ');
                if(command[0] == "End")
                {
                    break;
                }
                foreach (var car in cars.Where(c => c.Model == command[1]))
                {
                    car.IsTravelPossible(int.Parse(command[2]));
                }
            }
            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
