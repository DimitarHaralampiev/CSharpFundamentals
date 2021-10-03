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

            bool exist = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int leftNumber = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftNumber += arr[j];
                }

                int rightNumber = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    rightNumber += arr[j];
                }

                if(leftNumber == rightNumber)
                {
                    Console.WriteLine(i);
                    exist = true;
                    break;
                }
            }

            if(!exist)
            {
                Console.WriteLine("no");
            }
        }
    }
}
