using System;
using System.Numerics;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            BigInteger bigInteger = new BigInteger();

            bigInteger = number * num;

            Console.WriteLine(bigInteger);
        }
    }
}
