using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int max = int.MinValue;

            int sumFirstList = 0;
            int sumSecondList = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                sumFirstList += firstList[i];
                sumSecondList += secondList[i];
            }

            if (sumFirstList > sumSecondList)
            {
                Console.WriteLine($"First player wins! Sum: {sumFirstList + sumSecondList}");
            }
            else
            {
                for (int i = 0; i < firstList.Count; i++)
                {
                    if (max < secondList[i])

                    {
                        max = secondList[i];
                    }
                }
                Console.WriteLine($"Second player wins! Sum: {max}");
            }
        }
    }
}
