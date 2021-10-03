using System;
using System.Linq;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {

             //word = Console.ReadLine();

            while (true)
            {
                string word = Console.ReadLine();

                if (word == "end")
                {
                    break;
                }
                string result = string.Empty;

                for (int i = word.Length - 1; i >= 0; i--)
                {
                    result += word[i];
                }

                Console.WriteLine($"{word} = {result}");
            }

        }
    }
}
