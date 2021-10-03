using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int min = GetMinNumber(first, second, third);

            Console.WriteLine(min);
        }

        private static int GetMinNumber(int first, int second, int third)
        {
            int min = Math.Min(first, second);
            min = Math.Min(min, third);

            return min;
        }
    }
}
