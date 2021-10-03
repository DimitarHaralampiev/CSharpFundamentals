using System;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(", ");

            string text = Console.ReadLine();

            foreach (var word in words)
            {
                string name = word;

                if (text.Contains(word))
                {
                    text = text.Replace(word, new string('*', word.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
