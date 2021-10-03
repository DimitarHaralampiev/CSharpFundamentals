using System;
using System.Linq;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int firstElement = numbers[0];

                for (int j = 1; j < numbers.Length; j++)
                {
                    //int index = j - 1;
                    numbers[j - 1] = numbers[j];
                }
                numbers[numbers.Length - 1] = firstElement;
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
