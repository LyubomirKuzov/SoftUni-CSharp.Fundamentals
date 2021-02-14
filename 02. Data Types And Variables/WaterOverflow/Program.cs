using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCount = int.Parse(Console.ReadLine());

            int totalWaterAmount = 0;

            for (int i = 0; i < numbersCount; i++)
            {
                int waterAmount = int.Parse(Console.ReadLine());

                if (totalWaterAmount + waterAmount > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }

                totalWaterAmount += waterAmount;
            }

            Console.WriteLine(totalWaterAmount);
        }
    }
}
