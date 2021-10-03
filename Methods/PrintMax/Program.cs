using System;

namespace PrintMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("number = ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("number1 = ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("number2 = ");
            int number2 = int.Parse(Console.ReadLine());

            GetMax(number, number1);
            GetMax(number, number2);
            GetMax(number1, number2);

        }

        static void GetMax(int number, int number1)
        {
            if(number > number1)
            {
                Console.WriteLine($"Biggest number is {number}");
            }else
            {
                Console.WriteLine($"The biggest number is {number1}");
            }
        }
    }
}
