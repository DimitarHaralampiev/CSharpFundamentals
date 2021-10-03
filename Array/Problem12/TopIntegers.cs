using System;
using System.Linq;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isBigger = true;

                int currentNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {

                    int nextNumber = numbers[j];

                    if (currentNum <= nextNumber)
                    {
                        isBigger = false;
                        break;
                    }
                    
                }
                if (isBigger)
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}
