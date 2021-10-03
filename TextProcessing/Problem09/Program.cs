using System;

namespace Problem09
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine()
                .Split(" ");

            int sum = Multiply(str);

            Console.WriteLine(sum);
        }

        private static int Multiply(string[] str)
        {
            string first = str[0];
            string second = str[1];

            int minLenght = Math.Min(first.Length, second.Length);

            int sum = 0;

            for (int i = 0; i < minLenght; i++)
            {
                int firstNumber = first[i];
                int secondNumber = second[i];

                sum += firstNumber * secondNumber;

                if (first.Length > second.Length)
                {
                    sum += Add(first, minLenght);
                }
                else if (second.Length > first.Length)
                {
                    sum += Add(second, minLenght);
                }
            }

            return sum;
        }

        private static int Add(string first, int minLenght)
        {
            int sum = 0;

            for (int j = minLenght; j < first.Length; j++)
            {
                sum += first[j];
            }

            return sum;
        }
    }
}
