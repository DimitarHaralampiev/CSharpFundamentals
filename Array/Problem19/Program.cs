using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem19
{
    class Program
    {
        static void Main(string[] args)
         {
            List<int> listStr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "end")
                {
                    break;
                }

                string[] cmd = command.Split(" ");

                string first = cmd[0];

                if (first == "reverse")
                {
                    string second = cmd[1];
                    int start = int.Parse(cmd[2]);
                    string thord = cmd[3];
                    int finish = int.Parse(cmd[4]);

                    finish -= 1;
                    finish += start;

                    for (int i = start; i < finish; i++)
                    {
                        int temp = listStr[i];
                        listStr[i] = listStr[finish];
                        listStr[finish] = temp;

                        finish -= 1;
                        
                    }
                }
                else if(first == "sort")
                {
                    string second = cmd[1];
                    int start = int.Parse(cmd[2]);
                    string thord = cmd[3];
                    int finish = int.Parse(cmd[4]);

                    //finish -= 1;
                    finish += start;

                    for (int i = start; i < finish - 1; i++)
                    {
                        int current = listStr[i];

                        for (int j = i; j < finish; j++)
                        {
                            int next = listStr[j];

                            if(current > next)
                            {
                                int temp = next;
                                next = current;
                                current = temp;

                                listStr[i] = current;
                                listStr[j] = next;
                            }
                        }
                    }
                }
                else if(first == "remove")
                {
                    int num = int.Parse(cmd[1]);

                    for (int i = 0; i < num; i++)
                    {
                        listStr.Remove(listStr[0]);
                    }
                }
            }

            Console.WriteLine(string.Join(", ", listStr));
        }
    }
}
