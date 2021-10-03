using System;
using System.Linq;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                int arr = int.Parse(Console.ReadLine());
         
                sum += arr;
                array[i] = arr;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}
