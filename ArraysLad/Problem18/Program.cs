using System;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            double sumFirst = Factorial(first);
            double sumSecond = Factorial(second);

            double res = sumFirst / sumSecond;

            Console.WriteLine($"{res:F2}");
        }

        private static double Factorial(int number)
        {
            double fact = 1;

            for (int i = 2; i <= number; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
