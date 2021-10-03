
using System;
using System.Collections.Generic;
using System.Text;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char prevSymbol = '\0';

            StringBuilder sb = new StringBuilder();

            foreach (var letter in text)
            {
                if (letter != prevSymbol)
                {
                    sb.Append(letter);
                }

                prevSymbol = letter;
            }

            Console.WriteLine(sb);
        }
    }
}
