using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            double firstRacerTime = 0;
            double secondRacerTime = 0;

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int firstRacerCurrTime = numbers[i];

                if (firstRacerCurrTime == 0)
                {
                    firstRacerTime *= 0.8;
                }

                else
                {
                    firstRacerTime += firstRacerCurrTime;
                }

                int secondRacerCurrTime = numbers[numbers.Count - 1 - i];

                if (secondRacerCurrTime == 0)
                {
                    secondRacerTime *= 0.8;
                }

                else
                {
                    secondRacerTime += secondRacerCurrTime;
                }
            }

            if (firstRacerTime < secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {Math.Round(firstRacerTime, 1)}");
            }

            else
            {
                Console.WriteLine($"The winner is right with total time: {Math.Round(secondRacerTime, 1)}");
            }
        }
    }
}
