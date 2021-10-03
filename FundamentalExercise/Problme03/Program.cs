using System;

namespace Problme03
{
    class Program
    {
        static void Main(string[] args)
        {
            int countDay = int.Parse(Console.ReadLine());
            string groupOfPeople = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double priceOfDay = 0;
            double totalPrice = 0;
            double percentage = 1;

            if(groupOfPeople == "Students")
            {
                if(countDay >= 30)
                {
                    percentage = 0.85;
                }

                if (dayOfWeek == "Friday")
                {
                    priceOfDay = 8.45;
                }
                else if(dayOfWeek == "Saturday")
                {
                    priceOfDay = 9.80;
                }
                else
                {
                    priceOfDay = 10.46;
                }
            }
            else if(groupOfPeople == "Business")
            {
                if(countDay >= 100)
                {
                    countDay -= 10;
                }

                if (dayOfWeek == "Friday")
                {
                    priceOfDay = 10.90;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceOfDay = 15.60;
                }
                else
                {
                    priceOfDay = 16;
                }
            }
            else if(groupOfPeople == "Regular")
            {
                if(countDay >= 10 && countDay <= 20)
                {
                    percentage = 0.95;
                }

                if (dayOfWeek == "Friday")
                {
                    priceOfDay = 15;
                }
                else if (dayOfWeek == "Saturday")
                {
                    priceOfDay = 20;
                }
                else
                {
                    priceOfDay = 22.50;
                }
            }

            totalPrice = priceOfDay * countDay;
            Console.WriteLine($"Total price: {totalPrice * percentage:F2}");
        }
    }
}
