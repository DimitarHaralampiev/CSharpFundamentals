using System;
using System.Linq;

namespace Problem15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int left = numbers[numbers.Length / 2];
            int sumLeft = 0;

            for (int i = 0; i < numbers.Length / 2; i++)
            {  
                sumLeft += numbers[i];
            }
            Console.WriteLine(sumLeft);
        }
    }
}
