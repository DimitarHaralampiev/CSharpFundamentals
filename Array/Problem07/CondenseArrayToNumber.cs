using System;
using System.Linq;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

            int[] num = new int[numbers.Length - 1];
            int[] condence = new int[numbers.Length - 1];

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {

                sum = 0;

                num[i] = numbers[i] + numbers[i + 1];

                sum += num[i];

                condence[i] = sum;
            }

            for (int i = 0; i < condence.Length - 1; i++)
            {
                int[] nums = new int[condence.Length - 1];

                nums[i] = condence[i] + condence[i + 1];

                num[i] += nums[i];
            }
            Console.WriteLine(sum);
        }
    }
}
