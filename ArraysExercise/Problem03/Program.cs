using System;
using System.Linq;

namespace Problem03
{
    class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());

            int[] curNum = new int[line];
            int[] current = new int[line];

            for (int i = 0; i < line; i++)
            {

                int[] array1 = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int j = 0; j < array1.Length; j++)
                {
                    if (i % 2 == 0)
                    {
                        curNum[i] = array1[0];
                        current[i] = array1[1];
                    }
                    else
                    {
                        curNum[i] = array1[1];
                        current[i] = array1[0];
                    }
                }
            }

            for (int i = 0; i < curNum.Length; i++)
            {
                Console.Write(curNum[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < current.Length; i++)
            {
                Console.Write(current[i] + " ");
            }
          
        }
    }
}
