using System;
using System.Linq;

namespace Problme05
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int sumOdd = 0;
            int sumEven = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currNum = numbers[i];

                if (currNum % 2 == 0)
                {
                    sumEven += currNum;
                }
                else
                {
                    sumOdd += currNum;
                }
            }

            int result = sumEven - sumOdd;

            if (result < 0)
            {
                Console.WriteLine($"{result}");
            }
        }
    }
}
