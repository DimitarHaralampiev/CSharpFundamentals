using System;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int num = number;
            int fact = 1;
            int sum = 0;

            while(number != 0)
            {
                int n = number % 10;
                fact = 1;

                for(int i = 1; i <= n;i++)
                {
                    fact *= i;
                }

                sum += fact;
                number /= 10;
            }
            
            if(num == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
