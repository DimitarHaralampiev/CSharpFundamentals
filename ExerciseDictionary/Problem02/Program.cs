using System;
using System.Collections.Generic;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyValues = new Dictionary<string, int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                int number = int.Parse(Console.ReadLine());

                if (keyValues.ContainsKey(command))
                {
                    keyValues[command] += number;
                }
                else
                {
                    keyValues.Add(command, number);
                }
            }

            foreach (var item in keyValues)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
