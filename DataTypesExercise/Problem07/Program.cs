using System;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int totalLiters = 0;
            int capacity = 255;
           
            for (int i = 0; i < n; i++)
            {
                int liters = int.Parse(Console.ReadLine());

                totalLiters += liters;

                if (totalLiters > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                    totalLiters -= liters;
                }
            }

            Console.WriteLine(totalLiters);
        }
    }
}
