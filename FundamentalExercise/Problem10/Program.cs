using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            //string product = Console.ReadLine();

            double coins = 0.0;
            double sum = 0.0;

            while (command != "Start")
            {
                coins = double.Parse(command);

                if(coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 2 || coins == 1)
                {
                    sum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                double productPrice = 0;

                if (command == "Nuts")
                {
                    productPrice = 2;
                }
                else if (command == "Water")
                {
                    productPrice = 0.7;
                }
                else if (command == "Crisps")
                {
                    productPrice = 1.5;
                }
                else if (command == "Soda")
                {
                    productPrice = 0.8;
                }
                else if (command == "Coke")
                {
                    productPrice = 1;
                }

                if (productPrice != 0)
                {
                    if (sum >= productPrice)
                    {
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        sum -= productPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {sum:F2}");
        }
    }
}
