using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = double.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());


            double price = cost * 0.25;
            double result = 0;

            int count = 0;

            for (int i = 1; i <= month; i++)
            {
                count++;

                if (i % 2 != 0 && i > 1)
                {
                    result *= 0.84;
                }

                if (count == 4)
                {
                    result *= 1.25;
                    count = 0;
                    continue;
                }

                result += price;

            }

            double totalResult = result + price;
            //totalResult -= cost;

            if (result + price > cost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will have {totalResult - cost:f2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {cost - result:f2}lv. more.");
            }
        }
    }
}
