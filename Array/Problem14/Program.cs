using System;
using System.Linq;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int curNum = numbers[i];

                for (int j = i + 1; j < numbers.Length; j++)
                {
                    int nextNum = numbers[j];

                    if (curNum + nextNum == num)
                    {
                        Console.WriteLine($"{curNum} {nextNum}");
                    }
                }
            }
        }
    }
}
