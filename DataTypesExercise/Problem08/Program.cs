using System;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double totalVolume = 0;
            double maxTotal = double.MinValue;
            string empty = string.Empty;
            
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                totalVolume = Math.PI * radius * radius * (double)height;

                if(totalVolume > maxTotal)
                {
                    maxTotal = totalVolume;
                    empty = model;
                }
            }

            Console.WriteLine(empty);
        }
    }
}
