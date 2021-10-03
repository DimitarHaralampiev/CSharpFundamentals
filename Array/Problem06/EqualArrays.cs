using System;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            bool isValid = false;

            int sum = 0;
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == numbers1.Length)
                {

                    int arrNumbers = numbers[i];
                    int arrNumbers1 = numbers1[i];

                    if (arrNumbers == arrNumbers1)
                    {
                        sum += numbers[i];
                        isValid = true;
                    }
                    else
                    {
                        index = i;
                        isValid = false;
                        break;
                    }
                }
                else
                {
                    isValid = false;
                }
            }

            if (isValid)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {index} index");
            }
        }
    }
}
