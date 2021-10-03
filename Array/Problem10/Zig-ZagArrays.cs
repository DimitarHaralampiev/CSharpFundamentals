using System;
using System.Linq;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                    if (i % 2 == 0)
                    {
                        firstArray[i] = nums[0];
                        secondArray[i] = nums[1];
                    }
                    else
                    {
                        secondArray[i] = nums[0];
                        firstArray[i] = nums[1];
                    }                  
            }

            for (int i = 0; i < firstArray.Length; i++)
            {
                Console.Write($"{firstArray[i]} ");
            }

            Console.WriteLine();

            for (int i = 0; i < secondArray.Length; i++)
            {
                Console.Write($"{secondArray[i]} ");
            }
        }
    }
}
