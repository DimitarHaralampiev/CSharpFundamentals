using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] str = line.Split();

                int current = 0;

                if (str[0] == "Add")
                {
                    current = int.Parse(str[1]);
                    array.Add(current);
                }
                else
                {
                    current = int.Parse(str[0]);

                    for (int i = 0; i < array.Count; i++)
                    {
                        int passenger = array[i];

                        if (current + passenger <= maxCapacity)
                        {
                            array[i] += current;
                            break;
                        }
                    }
                }
            }

            Console.Write($"{string.Join(" ", array)} ");
        }
    }
}
