using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<string> name = new List<string>();

            for (int i = str.Length - 1; i >= 0; i--)
            {
                string[] strr = str[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                name.AddRange(strr);
            }

            Console.WriteLine(string.Join(" ", name));
        }
    }
}
