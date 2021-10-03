using System;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isValid = true;

            if (!HasCheckPassword(password))
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                isValid = false;
            }

            if (HasCheckDigitsAndLetters(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isValid = false;
            }

            if (!HasCheckCountDigits(password, 2))
            {
                Console.WriteLine("Password must have at least 2 digits");
                isValid = false;
            }
            
            if(isValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool HasCheckCountDigits(string password, int count)
        {
            int counts = 0;

            foreach (var item in password)
            {
                if (char.IsDigit(item))
                {
                    counts++;

                    if (counts == count)
                    {
                        return true;
                    }
                }
                
            }

            return false;
        }

        private static bool HasCheckDigitsAndLetters(string password)
        {
            foreach (var item in password)
            {
                if(!char.IsLetterOrDigit(item))
                {
                    return true;
                }
            }

            return false;
        }

        private static bool HasCheckPassword(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
