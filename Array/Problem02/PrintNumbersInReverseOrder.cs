using System;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] num = new int[n];

            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                num[i] = nums;
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write($"{num[i]} ");
            }
        }
    }
}
