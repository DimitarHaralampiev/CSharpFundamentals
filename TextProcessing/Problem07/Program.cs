using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> members = new Dictionary<string, string>();
            Dictionary<string, List<string>> membersBySide = new Dictionary<string, List<string>>();


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains("|"))
                {
                    string[] command = line.Split(" | ");

                    string forceUser = command[0];
                    string forceSide = command[1];

                    if (members.ContainsKey(forceUser))
                    {
                        continue;
                    }

                    if (!membersBySide.ContainsKey(forceSide))
                    {
                        membersBySide.Add(forceSide, new List<string>());
                    }

                    membersBySide[forceSide].Add(forceUser);
                    members.Add(forceUser, forceSide);
                }
                else
                {
                    string[] command = line.Split(" -> ");

                    string forceUser = command[0];
                    string forceSide = command[1];

                    if (!membersBySide.ContainsKey(forceSide))
                    {
                        membersBySide.Add(forceSide, new List<string>());
                    }

                    if (members.ContainsKey(forceUser))
                    {
                        string oldUser = members[forceUser];

                        membersBySide[oldUser].Remove(forceUser);
                        membersBySide[forceSide].Add(forceUser);
                        members[forceUser] = forceSide;
                    }
                    else
                    {
                        membersBySide[forceSide].Add(forceUser);
                        members.Add(forceUser, forceSide);
                    }

                    Console.WriteLine($"{forceUser} joins the {forceSide} side!");
                }
            }

            Dictionary<string, List<string>> result = membersBySide
                    .Where(x => x.Value.Count > 0)
                    .OrderByDescending(x => x.Value.Count)
                    .ThenBy(x => x.Key)
                    .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"! {item}");
                }
            }
        }
    }
}
