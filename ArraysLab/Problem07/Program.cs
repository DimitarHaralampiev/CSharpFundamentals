using System;
using System.Linq;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();
            
            int[] arr1 = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != arr1[i])
                {
                    Console.WriteLine($"Array are not identical. Found difference at {i} index");
                    return;
                }

                sum += arr[i];
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
                 
        }
    }
}
