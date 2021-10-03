using System;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = 0;
            int trashedMouses = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if(i % 2 == 0)
                {
                    trashedHeadsets += 1;
                }

                if(i % 3 == 0)
                {
                    trashedMouses += 1;
                }

                if(i % 6 == 0)
                {
                    trashedKeyboard += 1;
                }

                if(i % 12 == 0)
                {
                    trashedDisplay += 1;
                }
            }

            double rageExpenses = trashedDisplay * displayPrice +
                trashedKeyboard * keyboardPrice +
                trashedHeadsets * headsetPrice +
                trashedMouses * mousePrice;

            Console.WriteLine($"Rage expenses: {rageExpenses:F2} lv.");
        }
    }
}
