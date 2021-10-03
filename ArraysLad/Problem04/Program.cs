using System;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                PrintTrinagle(1,i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                PrintTrinagle(1,i);
            }

        }

        static void PrintTrinagle(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();

        }
    }
}
