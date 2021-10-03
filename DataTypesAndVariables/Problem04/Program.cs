using System;
using System.Numerics;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());

            int years = centuries * 100;
            double days = years * 365.24;
            long hours = (int)days * 24;
            BigInteger minutes = hours * 60;

            Console.WriteLine($"Centuries: {centuries} Years: {years} Days: {days} Hours: {hours} Minutes: {minutes}");
        }
    }
}
