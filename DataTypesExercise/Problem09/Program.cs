using System;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());

            if(yield < 100)
            {
                Console.WriteLine(0);
                Console.WriteLine(0);
                return;
            }

            long totlaSpice = 0;
            int days = 0;

            while (yield >= 100)
            {
                days += 1;
                totlaSpice += yield - 26;
                yield -= 10;
            }

            totlaSpice -= 26;

            Console.WriteLine(days);
            Console.WriteLine(totlaSpice);
        }
    }
}
