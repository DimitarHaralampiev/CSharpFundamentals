using System;

namespace Problem08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userName = Console.ReadLine()
                .Split(", ");

            foreach (var user in userName)
            {
                if (IsValid(user))
                {
                    Console.WriteLine(user);
                }
            }
        }

        private static bool IsValid(string user)
        {
            return IsValidLenght(user) && IsContains(user);
        }

        private static bool IsContains(string user)
        {
            foreach (var users in user)
            {
                if (!(char.IsLetterOrDigit(users) || user.Contains("-") || user.Contains("_")))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool IsValidLenght(string user)
        {
            return user.Length >= 3 && user.Length <= 16;
        }
    }
}
