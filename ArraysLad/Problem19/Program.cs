using System;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string number = Console.ReadLine();

                if(number == "END")
                {
                    break;
                }

                if(Palindrome(number))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }

        private static bool Palindrome(string number)
        {
            //int num = int.Parse(number);

            for (int i = 0; i < number.Length; i++)
            {
                int currentElement = number[0];
                int lastElement = number[number.Length - 1];

                if(currentElement == lastElement)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
