using System;
using System.Linq;

namespace Problem05
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string isDigit = string.Empty;
            string isDLetter = string.Empty;
            string isOther = string.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (char.IsDigit(ch))
                {
                    Console.Write(ch);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (char.IsLetter(ch))
                {
                    Console.Write(ch);
                }
            }

            Console.WriteLine();

            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];

                if (!char.IsLetter(ch) && !char.IsDigit(ch))
                {
                    Console.Write(ch);
                }
            }
        }
    }
}
