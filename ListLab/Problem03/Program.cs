using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();


            int min = (int)Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < min; i++)
            {
                result.Add(firstList[i]);
                result.Add(secondList[i]);
            }

            if(firstList.Count > secondList.Count)
            {
                result.AddRange(GetRemining(firstList, secondList)); 
            }
            else if(secondList.Count > firstList.Count)
            {
                result.AddRange(GetRemining(secondList, firstList));
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private static List<int> GetRemining(List<int> longerList, List<int> shorterList)
        {
            if(longerList.Count < shorterList.Count)
            {
                throw new ArgumentException();
            }

            List<int> resutl = new List<int>();

            for (int i = shorterList.Count; i < longerList.Count; i++)
            {
                resutl.Add(longerList[i]);
            }

            return resutl;
        }
    }
}