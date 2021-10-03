using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] name = line.Split();

                switch (name[0])
                {
                    case "Add":
                        int numberAdd = int.Parse(name[1]);
                        numbers.Add(numberAdd);
                        break;
                    case "Remove":
                        int numberRemove = int.Parse(name[1]);
                        numbers.Remove(numberRemove);
                        break;
                    case "RemoveAt":
                        int numberRemoveAt = int.Parse(name[1]);
                        numbers.RemoveAt(numberRemoveAt);
                        break;
                    case "Insert":
                        int numbersInsert = int.Parse(name[1]);
                        int num1 = int.Parse(name[2]);
                        numbers.Insert(num1, numbersInsert);
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
