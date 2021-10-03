using System;
using System.Linq;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] ch = Console.ReadLine()
                 .Split()
                 .Select(char.Parse)
                 .ToArray();

            for (int i = ch.Length - 1; i >= 0; i--)
            {
                Console.Write($"{(char)ch[i]} ");
            }
        }
    }
}
