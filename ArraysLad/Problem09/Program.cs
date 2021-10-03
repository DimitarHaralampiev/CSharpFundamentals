using System;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void GetMultipleOfEvenAndOdds(int number)
        {
            if(number % 2 == 0)
            {
                Console.Write($"Evens: {number} ");
            }
            else
            {
                Console.Write($"Odds: {number} ");
            }
        }

        static int GetSumOfEvenDigits(int even)
        {
            int result = 0;

            return result;
        }
    }
}
