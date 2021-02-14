using System;
using System.Numerics;

namespace Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowballsCount = int.Parse(Console.ReadLine());

            BigInteger highestSnowballValue = int.MinValue;
            int[] bestSnowballData = new int[3];

            for (int i = 0; i < snowballsCount; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                BigInteger snowballValue = (BigInteger)BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballValue = snowballValue;
                    bestSnowballData[0] = snowballSnow;
                    bestSnowballData[1] = snowballTime;
                    bestSnowballData[2] = snowballQuality;
                }
            }

            Console.WriteLine($"{bestSnowballData[0]} : {bestSnowballData[1]} = {highestSnowballValue} ({bestSnowballData[2]})");
        }
    }
}
