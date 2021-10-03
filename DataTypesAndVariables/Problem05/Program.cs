using System;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num = 0; 

            for (int i = 1; i <= n; i++)
            {
                num += i;
                sum = num % 10;

                if(sum == 5 || sum == 7 || sum == 11)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }
                sum = sum / 10;
            }
        }
    }
}
