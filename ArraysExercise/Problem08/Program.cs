using System;
using System.Linq;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int leftNumber = arr[i];
                int sum = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    int rightNumber = arr[j];

                    sum = leftNumber + rightNumber;

                    if(sum == number)
                    {
                        Console.Write($"{arr[i]} {arr[j]}");
                        Console.WriteLine();
                        //break;
                    }
                    
                }
                
            }
        }
    }
}
