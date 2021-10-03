using System;

namespace Problem25
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string n = Console.ReadLine();

            if (input == "string")
            {
                Console.WriteLine(GetString(n));
            }
            else if(input == "int")
            {
                Console.WriteLine(GetIntegers(n));
            }
            else if(input == "real")
            {
                GetDouble(n);
            }
        }

        private static void GetDouble(string n)
        {
            double sum = double.Parse(n);
            double number = 1.5;

            double totalSum = sum * number;

            Console.WriteLine($"{totalSum:f2}");
        }

        private static string GetString(string n)
        {
            return $"${n}$";
        }

        private static int GetIntegers(string n)
        {
            int sum = int.Parse(n);
            int number = 2;

            return sum * number;
        }
    }
}
