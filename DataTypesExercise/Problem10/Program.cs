using System;

namespace Problem10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int count = 0;
            int sum = n;

            while (n >= m)
            {
                count++;

                n -= m;

                if(n == sum / 2 && y > 0)
                {
                    n /= y;
                }
            }

            Console.WriteLine(n);
            Console.WriteLine(count);
        }
    }
}
