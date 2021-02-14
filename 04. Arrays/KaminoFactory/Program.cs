using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int elementsPerSequence = int.Parse(Console.ReadLine());

            int[] bestSequence = new int[elementsPerSequence];
            int bestCount = 0;
            int bestStartingIndex = int.MaxValue;
            int bestSum = 0;
            int totalSamplesCount = 0;
            int bestSampleIndex = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Clone them!")
                {
                    Console.WriteLine($"Best DNA sample {bestSampleIndex} with sum: {bestSum}.");
                    Console.WriteLine(string.Join(' ', bestSequence));
                    break;
                }

                int[] currSequence = input
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                totalSamplesCount++;

                int currCount = currSequence
                    .Any(x => x == 1)
                    ? 1
                    : 0;

                int startingIndex = 0;
                int currSequenceSum = currSequence.Sum();

                for (int i = 0; i < currSequence.Length - 1; i++)
                {
                    if (currSequence[i] == 1 && currSequence[i + 1] == 1)
                    {
                        startingIndex = i;
                        currCount++;
                    }
                }

                if ((currCount > bestCount)
                    || (currCount == bestCount && startingIndex < bestStartingIndex)
                    || (currCount == bestCount && startingIndex == bestStartingIndex && currSequenceSum > bestSum))
                {
                    bestCount = currCount;
                    bestStartingIndex = startingIndex;
                    bestSum = currSequenceSum;
                    bestSampleIndex = totalSamplesCount;
                    bestSequence = currSequence;
                }
            }
        }
    }
}
