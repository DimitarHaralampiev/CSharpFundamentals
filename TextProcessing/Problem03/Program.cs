using System;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine().ToLower();
            string replace = Console.ReadLine().ToLower();

            int index = replace.IndexOf(word);

            while (index != -1)
            {
                replace = replace.Remove(index, word.Length);
                index = replace.IndexOf(word);
            }

            Console.WriteLine(replace);
        }
    }
}
