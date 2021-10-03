using System;
using System.Collections.Generic;

namespace Problem10
{

    public class Vehicle
    {

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {

            List<Vehicle> vehicles = new List<Vehicle>();

            while (true)
            {
                string cmd = Console.ReadLine();

                if (cmd == "End")
                {
                    break;
                }

                string[] command = cmd.Split();

                string type = command[0];
                string model = command[1];
                string color = command[2];
                int horsePower = int.Parse(command[3]);

                Vehicle vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = color,
                    Horsepower = horsePower
                };

                vehicles.Add(vehicle);
            }

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Close the Catalogue")
                {
                    break;
                }

                Vehicle vehicle = GetVehicleType(vehicles, line);

                if (vehicle == null)
                {
                    continue;
                }

                if (vehicle.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                }

                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Color: {vehicle.Color}");
                Console.WriteLine($"Horsepower: {vehicle.Horsepower}");
            }

            double carsHorsePowerAvg = CarsHorsepowerType(vehicles, "car");
            double truckHorsePowerAvg = CarsHorsepowerType(vehicles, "truck");

            Console.WriteLine($"Cars have average horsepower of: {carsHorsePowerAvg:F2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckHorsePowerAvg:F2}.");
        }

        private static double CarsHorsepowerType(List<Vehicle> vehicles, string type)
        {
            int typeCount = 0;
            int typeHorsePowerTotal = 0;

            foreach (var vehicle in vehicles)
            {
                if (vehicle.Type == type)
                {
                    typeCount++;
                    typeHorsePowerTotal += vehicle.Horsepower;
                }
            }

            if (typeCount == 0)
            {
                return 0;
            }

             return (double)typeHorsePowerTotal / typeCount;
        }

        private static Vehicle GetVehicleType(List<Vehicle> vehicles, string model)
        {
            foreach (var item in vehicles)
            {
                if (item.Model == model)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
