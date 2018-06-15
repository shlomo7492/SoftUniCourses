using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RawData
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
                Car car = new Car();
                Engine engine = new Engine();
                Cargo cargo = new Cargo();
                engine.Speed = int.Parse(input[1]);
                engine.Power = int.Parse(input[2]);
                cargo.Weight = int.Parse(input[3]);
                cargo.Type = input[4];
                car.Model = input[0];
                car.Engine.Speed = engine.Speed;
                car.Engine.Power = engine.Power;
                car.Cargo.Weight = cargo.Weight;
                car.Cargo.Type = cargo.Type;
                car.Tire[0] = new Tire() { Presure = double.Parse(input[5]), Age = int.Parse(input[6])};
                car.Tire[1] = new Tire() { Presure = double.Parse(input[7]), Age = int.Parse(input[8]) };
                car.Tire[2] = new Tire() { Presure = double.Parse(input[9]), Age = int.Parse(input[10]) };
                car.Tire[3] = new Tire() { Presure = double.Parse(input[11]), Age = int.Parse(input[12]) };

                cars.Add(car);

            }
            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    {
                        foreach (Car car in cars.Where(c=>(c.Tire[0].Presure<1 
                                                            || c.Tire[1].Presure < 1 
                                                            || c.Tire[2].Presure < 1 
                                                            || c.Tire[3].Presure < 1)
                                                            &&c.Cargo.Type==command)
                                                            .ToList())
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
                case "flamable":
                    {
                        foreach (Car car in cars.Where(c => c.Engine.Power>250
                                                            && c.Cargo.Type == command)
                                                            .ToList())
                        {
                            Console.WriteLine(car.Model);
                        }
                    }
                    break;
                default:break;
            }

        }
    }
}
