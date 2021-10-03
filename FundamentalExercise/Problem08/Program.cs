using System;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMoney = double.Parse(Console.ReadLine());
            int countOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            int lightsabesCount = (int)Math.Ceiling(countOfStudents * 1.1);
            int beltsCount = countOfStudents - countOfStudents / 6;

            double totalPrice = priceOfLightsabers * lightsabesCount +
                priceOfRobes * countOfStudents +
                priceOfBelts * beltsCount;

            if(amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - amountOfMoney):f2}lv more.");
            }
        }
    }
}
