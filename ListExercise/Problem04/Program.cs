using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                string[] cmd = command.Split();

                string str = cmd[0];

                if (str == "Add")
                {
                    int num = int.Parse(cmd[1]);
                    numbers.Add(num);
                }
                else if(str == "Insert")
                {
                    int num = int.Parse(cmd[1]);
                    int number = int.Parse(cmd[2]);

                    if (isValid(num, numbers))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.Insert(num, number);
                }
                else if (str == "Remove")
                {
                    int num = int.Parse(cmd[1]);

                    if (isValid(num, numbers))
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    numbers.RemoveAt(num);
                }
                else if (str == "Shift")
                {
                    string com = cmd[1];
                    int num = int.Parse(cmd[2]);

                    if (com == "left")
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int firstElement = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(firstElement);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < num; i++)
                        {
                            int lastElement = numbers[numbers.Count - 1];
                            numbers.RemoveAt(numbers.Count - 1);
                            numbers.Insert(0, lastElement);
                        }
                    }
                }
                
            }

            foreach (var item in numbers)
            {
                Console.Write($"{item} ");
            }
        }

        private static bool isValid(int idx, List<int> numbers)
        {
            return idx < 0 || idx > numbers.Count - 1;
        }
    }
}
