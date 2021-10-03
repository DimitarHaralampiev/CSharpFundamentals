using System;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            int count = GetCountOfString(str);

            Console.WriteLine(count);
        }

        private static int GetCountOfString(string str)
        {
            int count = 0;
            str = str.ToLower();

            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if(ch == 'a' 
                    || ch == 'e' 
                    || ch == 'i'
                    || ch == 'o'
                    || ch == 'u'
                    || ch == 'y')
                {
                    count++;
                }
            }

            return count;
        }
    }
}
