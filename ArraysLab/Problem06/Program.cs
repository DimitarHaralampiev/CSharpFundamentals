using System;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < num.Length; i++)
            {
                if(num[i] % 2 == 0)
                {
                    evenSum += num[i];
                }
                else
                {
                    oddSum += num[i];
                }
            }

            int difference = evenSum - oddSum;
            Console.WriteLine(difference);

        }
    }
}
