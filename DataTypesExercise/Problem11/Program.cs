using System;
using System.Numerics;

namespace Problem11
{
    class Program
    {
        static void Main(string[] args)
        {
            int firtsLine = int.Parse(Console.ReadLine());

            BigInteger maxSnowballValue = -1;
            string empty = string.Empty;

            for (int i = 0; i < firtsLine; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballVolume = BigInteger.Pow(snowballSnow / snowballTime, snowballQuality);

                if(snowballVolume > maxSnowballValue)
                {
                    maxSnowballValue = snowballVolume;
                    empty = $"{snowballSnow} : {snowballTime} = {snowballVolume} ({snowballQuality})";
                }
            }

            Console.WriteLine(empty);
        }
    }
}
