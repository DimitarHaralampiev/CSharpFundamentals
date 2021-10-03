using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> keyValuePairs = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string userName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!keyValuePairs.ContainsKey(userName))
                {
                    keyValuePairs.Add(userName, new List<double>());
                }

                keyValuePairs[userName].Add(grade);
            }

            Dictionary<string, List<double>> sortByGrades = keyValuePairs
                .OrderByDescending(x => x.Value.Average())
                .Where(x => x.Value.Average() >= 4.50)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortByGrades)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():F2}");
            }
        }
    }
}