using System;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                nums[i] = num;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                Console.Write($"{nums[i]} ");
            }
            Console.WriteLine();

            Console.WriteLine(sum);
        }
    }
}
