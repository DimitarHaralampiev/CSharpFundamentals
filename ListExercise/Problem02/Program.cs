using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> newList = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split();

                string str = parts[0];

                if (parts.Length == 4)
                {
                    bool isRemoved = newList.Remove(str);

                    if (!isRemoved)
                    {
                        Console.WriteLine($"{str} is not in the list!");
                    }                    
                }
                else
                {
                    if (newList.Contains(str))
                    {
                        Console.WriteLine($"{str} is already in the list!");
                    }
                    else
                    {
                        newList.Add(str);
                    }
                }
                
            }

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
