using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;

namespace Problme07
{

    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                .Split("@")
                .ToList();

            Console.WriteLine($"Place {list.Count} has Valentine's day.");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Love!")
                {
                    break;
                }

                string[] command = line.Split();
                string parts = command[0];
                int num = int.Parse(command[1]);

                if (parts == "Jump")
                {
                    int count = list.Count - num;
                    num += num;

                    if (count > 0)
                    {

                    }
                }
            }
        }
    }
}
