using System;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = (double)peopleCount / capacity;

            Console.WriteLine(Math.Ceiling(courses));
        }
    }
}
