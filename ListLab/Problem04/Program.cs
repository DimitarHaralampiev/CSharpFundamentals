using System;
using System.Collections.Generic;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> str = new List<string>();

            for (int i = 0; i < n; i++)
            {
                str.Add(Console.ReadLine());
            }

            str.Sort();

            for (int i = 0; i < str.Count; i++)
            {
                Console.Write($"{i + 1}.{str[i]}");
                Console.WriteLine();
            }
        }
    }
}
