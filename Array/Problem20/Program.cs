using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem20
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> str = new List<string>();

            while (true)
            {
                List<string> listStr = Console.ReadLine()
                    .Split()
                    .ToList();

                string command = listStr[0];

                if (command == "end")
                {
                    break;
                }

                if (command == "Chat")
                {
                    AddCommand(str, listStr);
                }
                else if(command == "Delete")
                {
                    DeleteCommand(str, listStr);
                }
                else if(command == "Edit")
                {
                    EditCommand(str, listStr);
                }
                else if(command == "Pin")
                {
                    IsValidContains(str, listStr);
                }
                else if(command == "Spam")
                {
                    GetAddMessage(str, listStr);
                }

                //str = listStr;
            }

            Console.WriteLine(string.Join(" ", str));
        }

        private static void EditCommand(List<string> str, List<string> listStr)
        {
            string commandName = listStr[1];
            string commandName2 = listStr[2];

            listStr[1] = commandName2;

            str.Remove(commandName);

            str.Add(listStr[1]);
        }

        private static void DeleteCommand(List<string> str, List<string> listStr)
        {
            string commandName = listStr[1];

            if (str.Contains(commandName))
            {
                str.Remove(commandName);
            }
        }

        private static void AddCommand(List<string> str, List<string> listStr)
        {
            string commandName = listStr[1];

            str.Add(commandName);
        }

        private static void GetAddMessage(List<string> str, List<string> listStr)
        {
            for (int i = 1; i < listStr.Count; i++)
            {
                str.Add(listStr[i]);
            }
        }

        private static void IsValidContains(List<string> str, List<string> listStr)
        {
            string commandName = listStr[1];

            if (listStr.Contains(commandName))
            {
                str.Remove(commandName);

                str.Add(commandName);
            }
        }
    }
}
