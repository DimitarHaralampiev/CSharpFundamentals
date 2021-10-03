using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            //List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] < 0)
                {
                    numbers.RemoveAt(i);

                    i--;
                }

            }

            numbers.Reverse();

            if (numbers.Count > 0)
            {
                Console.Write($"{string.Join(" ", numbers)} ");
            }
            else
            {
                Console.WriteLine("empty"); ;
            }
        }
    }
}
