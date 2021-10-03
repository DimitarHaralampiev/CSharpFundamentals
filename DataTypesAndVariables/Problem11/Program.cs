using System;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lenght: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            double radius = (lenght + width + height) / 3;

            Console.WriteLine($"Pyramid volume: {radius:F2}");
        }
    }
}
