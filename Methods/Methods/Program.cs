using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("Peter");
        }
        static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
    }
}
