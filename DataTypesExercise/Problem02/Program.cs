using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            int total = 0;

            while(number != 0)
            {
                total = number % 10;
                number /= 10;
                sum += total;
            }

            Console.WriteLine(sum);
        }
    }
}
