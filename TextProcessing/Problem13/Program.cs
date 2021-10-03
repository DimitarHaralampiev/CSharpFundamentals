using System;
using System.Text;

namespace Problem13
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            foreach (var letter in text)
            {
                char encryptedLetter = (char)(letter + 3);

                sb.Append(encryptedLetter);
            }

            Console.WriteLine(sb);
        }
    }
}
