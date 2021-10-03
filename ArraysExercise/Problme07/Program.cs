using System;
using System.Linq;

namespace Problme07
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int bestSequences = 0;
            int bestSequencesNum = 1;

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if(count > bestSequences)
                {
                    bestSequences = count;
                    bestSequencesNum = arr[i];
                }
            }

            for (int i = 0; i <= bestSequences; i++)
            {
                Console.Write($"{bestSequencesNum} ");
            }

            

        }
    }
}
