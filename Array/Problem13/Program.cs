using System;
using System.Linq;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int max = int.MinValue;

            int nums = 0;

            for (int i = 0; i < n.Length; i++)
            {
                int curNum = n[i];
                int count = 1;

                for (int j = i + 1; j < n.Length; j++)
                {
                    int nextNum = n[j];

                    if (curNum != nextNum)
                    {
                        break;
                    }

                    count++;
                }

                if (count > max)
                {
                    max = count;
                    nums = n[i];
                }
            }

            for (int i = 0; i < max; i++)
            {
                Console.Write($"{nums} ");
            }
        }
    }
}
