using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = decimal.Parse(Console.ReadLine());

            decimal USD = pounds * 1.31m;

            Console.WriteLine($"{USD:F3}");
        }
    }
}
