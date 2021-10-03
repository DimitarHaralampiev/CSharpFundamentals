using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("!")
                .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Go Shopping!")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];
                

                if (command == "Urgent")
                {
                    string item = parts[1];
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list.Contains(item))
                        {
                            continue;
                        }
                        list.Insert(0, item);
                        
                    }
                }

                if (command == "Unnecessary")
                {
                    string item = parts[1];
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list.Contains(item))
                        {
                            list.Remove(item);
                        }
                    }
                }

                if (command == "Correct")
                {
                    string olditem = parts[1];
                    string newItem = parts[2];

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == olditem)
                        {
                            
                            list.Remove(olditem);
                            list.Insert(i, newItem);
                        }
                    }
                }

                if (command == "Rearrange")
                {
                    string item = parts[1];

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == item)
                        {
                            list.RemoveAt(i);
                            list.Add(item);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(", ", list));
        }
    }
}
