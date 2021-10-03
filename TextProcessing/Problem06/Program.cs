using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem06
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> studentsByPoints = new Dictionary<string, decimal>();
            Dictionary<string, int> courseBySubmission = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "exam finished")
                {
                    break;
                }

                string[] command = line.Split("-");

                string userName = command[0];
                string language = command[1];

                if (language == "banned")
                {
                    studentsByPoints.Remove(userName);
                    continue;
                }

                if (!studentsByPoints.ContainsKey(userName))
                {
                    decimal points = decimal.Parse(command[2]);

                    studentsByPoints.Add(userName, points);

                    if (!courseBySubmission.ContainsKey(language))
                    {
                        courseBySubmission.Add(language, 1);
                    }
                    else
                    {
                        courseBySubmission[language] += 1;
                    }
                }
                else
                {
                    decimal points = decimal.Parse(command[2]);

                    if (studentsByPoints[userName] <= points)
                    {
                        studentsByPoints[userName] = points;
                    }

                    courseBySubmission[language] += 1;
                }
            }

            Dictionary<string, decimal> sortedByPoints = studentsByPoints
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Results:");

            foreach (var kvp in sortedByPoints)
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Dictionary<string, int> sortedBySub = courseBySubmission
                .Where(x => x.Value > 0)
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine("Submissions:");

            foreach (var kvp in sortedBySub)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
