using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list = new List<int>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] cmd = command.Split();
                
                string str = cmd[0];
                int nums = int.Parse(cmd[1]);

                if (str == "Insert")
                {   
                    int idx = int.Parse(cmd[2]);
                    numbers.Insert(idx, nums);
                }
                else if (str == "Delete")
                {
                    numbers.RemoveAll(n => n == nums);
                }
            }

            Console.Write($"{string.Join(" ", numbers)} ");
        }
    }
}
