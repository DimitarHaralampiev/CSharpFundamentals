using System;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfProducts = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            PrintResultOfProducts(nameOfProducts, count);
        }

        static void PrintResultOfProducts(string products, double count)
        {
            double coffee = 1.50;
            double water = 1.00;
            double coke = 1.40;
            double snacks = 2.00;

            if(products == "coffee")
            {
                Console.WriteLine($"{coffee * count:F2}");
            }
            else if(products == "water")
            {
                Console.WriteLine($"{water * count:F2}");
            }
            else if(products == "coke")
            {
                Console.WriteLine($"{coke * count:F2}");
            }
            else if(products == "snacks")
            {
                Console.WriteLine($"{snacks * count:F2}");
            }
        }
    }
}
