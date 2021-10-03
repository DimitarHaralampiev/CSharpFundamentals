using System;
using System.Collections.Generic;

namespace Problem16
{

    public class Car
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

    public class Truck
    {
        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

    public class Catalogue
    {
        public Car Car { get; set; }

        public Truck Truck { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Catalogue> catalogues = new List<Catalogue>();

            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();


            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] cmd = command.Split();

                string type = cmd[0];
                string model = cmd[1];
                string color = cmd[2];
                int horsepower = int.Parse(cmd[3]);

                if (type == "truck")
                {
                    Truck truck = new Truck()
                    {
                        Type = type,
                        Model = model,
                        Color = color,
                        Horsepower = horsepower
                    };

                    trucks.Add(truck);
                }
                else if (type == "car")
                {
                    Car car1 = new Car
                    {
                        Type = type,
                        Model = model,
                        Color = color,
                        Horsepower = horsepower
                    };


                    cars.Add(car1);
                }
            }

            while (true)
            {
                string md = Console.ReadLine();

                if (md == "Close the Catalogue")
                {
                    break;
                }
                foreach (var item in cars)
                {
                    if (md == item.Model)
                    {
                        Console.WriteLine($"Type: {item.Type} \n Model: {item.Model} \n " +
                        $"Color: {item.Color} \n Horsepower: {item.Horsepower}");
                    }
                }

                foreach (var item in trucks)
                {
                    if (md == item.Model)
                    {
                        Console.WriteLine($"Type: {item.Type} \n Model: {item.Model} \n " +
                        $"Color: {item.Color} \n Horsepower: {item.Horsepower}");
                    }
                }
            }
            int totalCars = 0;
            int count = 0;

            foreach (var item in cars)
            {
                totalCars += item.Horsepower;
                count++;
            }
            Console.WriteLine(totalCars / count);
        }

    }
}
