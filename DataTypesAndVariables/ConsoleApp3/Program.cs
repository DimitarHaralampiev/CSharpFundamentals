using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double meters = double.Parse(Console.ReadLine());

            double kilometers = meters / 1000;

            Console.WriteLine($"{kilometers:F2}");
        }
    }
}
