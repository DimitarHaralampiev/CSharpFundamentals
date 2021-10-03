using System;
using System.Collections.Generic;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine()
                    .Split();

                string command = parts[0];

                if (command == "register")
                {
                    string userName = parts[1];
                    string placeNumber = parts[2];

                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {placeNumber}");
                        continue;
                    }
                    else
                    {
                        users.Add(userName, placeNumber);
                    }

                    Console.WriteLine($"{userName} registered {placeNumber} successfully");
                }
                else if(command == "unregister")
                {
                    string userName = parts[1];
                    //string placeNumber = parts[2];

                    if (!users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                        continue;
                    }
                    else
                    {
                        users.Remove(userName);
                    }

                    Console.WriteLine($"{userName} unregistered successfully");
                }
            }

            foreach (var kvp in users)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
