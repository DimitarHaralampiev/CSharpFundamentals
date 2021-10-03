using System;
using System.Linq;

namespace Problem21
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arr1 = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(char.Parse)
                 .ToArray();

            char[] arr2 = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(char.Parse)
                 .ToArray();

            int countArr2 = 0;
            int countArr1 = 0;

            for (int i = 0; i < arr1.Length; i++)
            {

                for (int j = 0; j < arr2.Length; j++)
                {
                    if(arr1[i] < arr2[j])
                    {
                        arr1 = arr2;
                        countArr2++;
                    }
                    else if(arr1[i] > arr2[j])
                    {
                        countArr1++;
                    }
                }
            }

            if(countArr1 > countArr2)
            {
                Console.WriteLine("Array second is very big");
            }
            else if(countArr2 > countArr1)
            {
                Console.WriteLine("Array first is very big");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }
}
