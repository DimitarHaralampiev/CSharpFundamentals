using System;
using System.Linq;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string username = "";
            int count = 0;

            for (int i = password.Length - 1; i >= 0; i--)
            {
                username += password[i];
            }

            bool isLoged = false;
            bool isBlocked = false;

            while (!isLoged && !isBlocked)
            {
                string inputPassword = Console.ReadLine();

                if (inputPassword == username)
                {
                    Console.WriteLine($"User {password} logged in.");
                    isLoged = true;
                }
                else
                {
                    count++;

                    if (count == 4)
                    {
                        Console.WriteLine($"User {password} blocked!");
                        isBlocked = true;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
                
            }
        }
    }
}
