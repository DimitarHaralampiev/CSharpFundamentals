using System;
using System.Linq;

namespace Problem24
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
            int n = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currentNumber = numbers[i];

                int count = 0;

                for (int j = i + 1; j < numbers.Length - 1; j++)
                {
                    int nextNumber = numbers[j];

                    if (currentNumber >= nextNumber)
                    {
                        break;
                    }

                    if (nextNumber > currentNumber)
                    {
                        count++;
                        currentNumber = nextNumber;
                   }
                }

                if (count > maxLine)
                {
                    maxLine = count;                    
                }
            }
            Console.WriteLine($"{maxLine}");
        }
    }
}
