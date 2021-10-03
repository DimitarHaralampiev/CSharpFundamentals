using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();


            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "end")
                {
                    break;
                }

                string[] command = cmd.Split("/");

                string type = command[0];
                string brand = command[1];
                string model = command[2];

                if (type == "Car")
                {
                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        Horsepower = int.Parse(command[3])
                    };

                    cars.Add(car);
                }
                
                if (type == "Truck")
                {
                    Truck truck = new Truck
                    {
                        Brand = brand,
                        Model = model,
                        Weight = double.Parse(command[3])
                    };
                    
                    trucks.Add(truck);
                }
            }

            foreach (var item in cars)
            {
                List<Car> cars1 = cars
                    .OrderBy(x => x.Horsepower)
                    .ToList();

                foreach (var items in cars1)
                {
                    Console.WriteLine($"Cars: \n {items.Brand}: {items.Model} - {items.Horsepower}hp");
                }
                break;
            }

            foreach (var item in trucks)
            {
                List<Truck> trucks1 = trucks
                    .OrderBy(x => x.Weight)
                    .ToList();

                foreach (var items in trucks1)
                {
                    Console.WriteLine($"Trucks: \n {items.Brand}: {items.Model} - {items.Weight}kg");
                }
                break;
            }
            
        }
    }
}
