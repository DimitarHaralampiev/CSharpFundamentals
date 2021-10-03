using System;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string line = Console.ReadLine();

            Console.WriteLine($"{firstName}{line}{lastName}");
        }
    }
}
