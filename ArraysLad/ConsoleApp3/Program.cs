using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(PrintNumber(n)); 
        }

        static string PrintNumber(int num)
        {
            string str = string.Empty;

            if(num > 0)
            {
                str = $"The number {num} is positive";
            }
            else if(num < 0)
            {
                str = $"The number {num} is negative";
            }
            else
            {
                str = $"The number {num} is zero";
            }

            return str;
        }
    }
}
