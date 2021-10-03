using System;

namespace Problme01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days =
            {
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thorsday",
                "Friday",
                "Saturday",
                "Sunday"
            };

            int day = int.Parse(Console.ReadLine());

            if(day <= 0 || day > 7)
            {
                Console.WriteLine("Invalida day!");
            }
            else
            {
                Console.WriteLine(days[day - 1]);
            }
        }
    }
}
