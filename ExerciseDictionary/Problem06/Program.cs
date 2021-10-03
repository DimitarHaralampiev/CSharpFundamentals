using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] cmd = command.Split(" : ");

                string course = cmd[0];
                string userName = cmd[1];

                if (!keyValuePairs.ContainsKey(course))
                {
                    keyValuePairs.Add(course, new List<string>());
                }

                keyValuePairs[course].Add(userName);
            }

            Dictionary<string, List<string>> sortedList = keyValuePairs
                .OrderByDescending(x => x.Value.Count)
                .ToDictionary(x => x.Key, x => x.Value);
            
            foreach (var kvp in sortedList)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
