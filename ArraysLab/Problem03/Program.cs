using System;
using System.Linq;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] num = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(decimal.Parse)
                .ToArray();
            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine($"{num[i]} => {(int)Math.Round(num[i], MidpointRounding.AwayFromZero)}");
            }
           
        }
    }
}
