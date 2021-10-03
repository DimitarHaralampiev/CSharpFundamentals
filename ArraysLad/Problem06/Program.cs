using System;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double result = AreaRectangle(a, b);

            Console.WriteLine(result);
        }

        static double AreaRectangle(double a, double b)
        {
            return a * b;
        }
    }
}
