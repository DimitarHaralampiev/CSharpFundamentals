using System;

namespace Problem17
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine()
                .Split(" |");

            int healt = 100;

            for (int i = 0; i < arr.Length; i++)
            {
                string name = arr[0];
                int number = int.Parse(arr[1]);

                if (name == "potion")
                {
                    Console.WriteLine($"You healed for {number} hp.");
                }
                else if(name == "chest")
                {
                    Console.WriteLine($"You found {number} bitcoins.");

                    if (healt <= 0)
                    {
                        Console.WriteLine($"You slayed {number}");
                        Console.WriteLine($"You died! Killed  by {number}");
                        Console.WriteLine($"Best room: {i}");
                    }
                }
                else
                {
                    Console.WriteLine($"You slayed {name}.");
                }
            }
        }
    }
}
