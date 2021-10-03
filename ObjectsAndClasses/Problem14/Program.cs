using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Article> listArt = new List<Article>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();

                string[] cmd = command.Split(", ");

                string first = cmd[0];
                string second = cmd[1];
                string third = cmd[2];

                Article article1 = new Article()
                {
                    Title = first,
                    Content = second,
                    Author = third
                };

                listArt.Add(article1);
            }

            string com = Console.ReadLine();

            if (com == "title")
            {
                List<Article> list = listArt
                    .OrderBy(x => x.Title)
                    .ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(string.Join(", ", item));
                }
            }

            else if(com == "content")
            {
                List<Article> list = listArt
                    .OrderBy(x => x.Content)
                    .ToList();

                foreach (var item in list)
                {
                    Console.WriteLine(string.Join(", ", item));
                }
            }
        }
    }
}
