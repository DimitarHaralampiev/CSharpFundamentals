using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem05
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

            int sumFirstList = 0;
            int sumSecondList = 0;

            for (int i = 0; i < firstList.Count; i++)
            {
                sumFirstList += firstList[i];
                sumSecondList += secondList[i];
            }

            if (sumFirstList > sumSecondList)
            {
                Console.WriteLine($"First player wins! Sum: {sumFirstList}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {sumSecondList}");
            }
        }
    }
}
