using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem18
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfExperienced = double.Parse(Console.ReadLine());
            int countOfBattles = int.Parse(Console.ReadLine());

            int count = 0;
            double bonusThird = 0;
            double bonusFifht = 0;
            double total = 0;

            for (int i = 0; i < countOfBattles; i++)
            {
                double battle = double.Parse(Console.ReadLine());

                count++;

                if (count % 3 == 0)
                {
                    bonusThird += battle * 1.15;
                    battle = bonusThird;
                }
                else if(count % 5 == 0)
                {
                    bonusFifht = battle *= 0.9;
                    battle = bonusFifht;
                }

                total += battle;

                if (total >= amountOfExperienced)
                {
                    Console.WriteLine($"Player successfully collected his needed experience for {count} battles.");
                    break;
                }
            }

            if(total < amountOfExperienced)
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {amountOfExperienced - total:f2} more needed.");
            }
        }
    }
}
