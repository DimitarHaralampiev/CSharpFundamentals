using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> keyValuePairs = new Dictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] command = line.Split(" -> ");

                string companyName = command[0];
                string employeeId = command[1];

                if (!keyValuePairs.ContainsKey(companyName))
                {
                    keyValuePairs.Add(companyName, new List<string>());
                }

                keyValuePairs[companyName].Add(employeeId);
            }

            Dictionary<string, List<string>> sortedByName = keyValuePairs
                .OrderBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedByName)
            {
                Console.WriteLine($"{kvp.Key}");

                List<string> list = kvp
                    .Value
                    .Distinct()
                    .ToList();

                foreach (var item in list)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
