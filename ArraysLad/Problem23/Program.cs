using System;
using System.Linq;

namespace Problem23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int maxLine = int.MinValue;
            int num = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];
                int count = 0;

                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    int nextNumber = numbers[j];

                    if (currentNumber == nextNumber)
                    {
                        count++;
                    }
                }

                if(count > maxLine)
                {
                    maxLine = count;
                    num = currentNumber;
                }
            }

            Console.WriteLine($"{maxLine} {num}");
        }
    }
}
