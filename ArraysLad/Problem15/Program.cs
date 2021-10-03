using System;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Sum(first, second);
            int totalSum = Subtract(sum, third);

            Console.WriteLine(totalSum);
        }

        private static int Subtract(int sum, int third)
        {
            return sum - third;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
