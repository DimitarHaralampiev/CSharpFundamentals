using System;
using System.Linq;

namespace Problem22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();

                if(line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if(command == "exchange")
                {
                    int idx = int.Parse(parts[1]);
                    Exchange(number, idx);
                }
                else if(command == "max")
                {
                    string parameter = parts[1];

                    int idx = GetMax(number, parameter);

                    if (idx == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(idx);
                    }
                }
                else if (command == "min")
                {
                    string parameter = parts[1];

                    int idx = GetMin(number, parameter);

                    if (idx == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(idx);
                    }
                }
                else if (command == "first")
                {
                    int count = int.Parse(parts[1]);
                    string parameter = parts[2];

                    if (count > number.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] firstElements = GetFirstElements(number, count, parameter);

                    PrintArray(firstElements);
                }
                else if (command == "last")
                {
                    int count = int.Parse(parts[1]);
                    string parameter = parts[2];

                    if (count > number.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] lastElements = GetLastElements(number, count, parameter);

                    PrintArray(lastElements);
                }
            }

            Console.WriteLine($"[{string.Join(" ", number)}]");
        }

        private static void PrintArray(int[] firstElements)
        {
            Console.Write("[");

            bool found = false;

            foreach (var firstElement in firstElements)
            {
                if (firstElement != -1)
                {
                    if (found)
                    {
                        Console.Write($", {firstElement}");
                    }
                    else
                    {
                        Console.Write($"{firstElement}");
                        found = true;
                    }
                }
            }
            Console.WriteLine("]");
        }

        private static int[] GetLastElements(int[] number, int count, string parameter)
        {
            int[] result = new int[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }

            int parity = GetParity(parameter);
            int idx = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int numbers = number[i];
                if (numbers % 2 == parity)
                {
                    result[idx] = numbers;
                    idx += 1;

                    if (idx >= result.Length)
                    {
                        break;
                    }
                }
            }   

            return result.Reverse().ToArray(); 
        }

        private static int[] GetFirstElements(int[] number, int count, string parameter)
        {
            int[] result = new int[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }

            int parity = GetParity(parameter);
            int idx = 0;

            foreach (var numbers in number)
            {
                if (numbers % 2 == 0)
                {
                    result[idx] = numbers;
                    idx += 1;

                    if(idx >= result.Length)
                    {
                        break;
                    }
                }
            }

            return number;
        }

        private static int GetParity(string parameter)
        {
            if (parameter == "even")
            {
                return 0;
            }

            return 1;
        }

        private static int GetMin(int[] number, string parameter)
        {
            int parity = GetParity(parameter);

            int minNumber = int.MaxValue;
            int idx = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = number[i];

                if (currentNumber <= minNumber
                    && currentNumber % 2 == parity)
                {
                    minNumber = currentNumber;
                    idx = i;
                }
            }

            return idx;
        }

        private static int GetMax(int[] number, string parameter)
        {
            int parity = GetParity(parameter);

            int maxNumber = int.MinValue;
            int idx = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int currentNumber = number[i];

                if(currentNumber >= maxNumber 
                    &&  currentNumber % 2 == parity)
                {
                    maxNumber = currentNumber;
                    idx = i;
                }
            }

            return idx;
        }

        private static void Exchange(int[] number, int idx)
        {
            if (idx < 0 || idx >= number.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int rotation = 0; rotation < idx; rotation++)
            {
                int firstNumber = number[0];

                for (int i = 1; i < number.Length; i++)
                {
                    number[i - 1] = number[i];
                }
                number[number.Length - 1] = firstNumber;
            }
        }
    }
}
