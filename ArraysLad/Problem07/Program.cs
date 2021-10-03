using System;

namespace Problem07
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write(name, count);
            }
            
        }

        static string RepeatString(string name, int count)
        {
            string result = string.Empty;

            for (int i = 0; i < count; i++)
            {
                result = name;
            }
            return result;
        }
    }
}
