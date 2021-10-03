using System;
using System.Linq;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
           
                Console.Write(string.Join(" ", str.Reverse()));
        }
    }
}
