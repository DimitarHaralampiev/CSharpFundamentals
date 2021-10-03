using System;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstNumber = long.Parse(Console.ReadLine());
            long secondNumber = long.Parse(Console.ReadLine());
            long thirdNumber = long.Parse(Console.ReadLine());
            long fourNumber = long.Parse(Console.ReadLine());

            long result = (firstNumber + secondNumber) / thirdNumber * fourNumber;
            Console.WriteLine(result);
        }
    }
}
