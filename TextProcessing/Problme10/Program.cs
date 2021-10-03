using System;
using System.Linq;

namespace Problme10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split("\\");

            string extension = text[text.Length - 1];

            string[] str = extension.Split(".");

            Console.WriteLine($"File name: {str[0]}");
            Console.WriteLine($"File extension: {str[1]}");
        }
    }
}
