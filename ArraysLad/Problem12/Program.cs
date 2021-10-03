using System;

namespace Problem12
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            char ch1 = char.Parse(Console.ReadLine());

            char start = ch;
            char end = ch1;

            if(start > end)
            {
                ch = end;
                ch1 = start;
            }

            GetBetweenChar(ch, ch1);
        }

        private static void GetBetweenChar(char ch, char ch1)
        {          
            for (int chr = (int)ch+1 ; chr < ch1; chr++)
            {
                Console.Write($"{(char)chr} ");
            }
        }
    }
}
