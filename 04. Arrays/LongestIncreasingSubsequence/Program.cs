using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestIncreasingSubsequence
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialSequence = Console.ReadLine()
                            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                            .Select(int.Parse)
                            .ToList();

            int maxLength = 0;
            int lastIndex = -1;

            List<int> len = new List<int>();
            List<int> prev = new List<int>();

            for (int i = 0; i < initialSequence.Count; i++)
            {
                len.Add(1);
                prev.Add(-1);

                for (int j = 0; j < i; j++)
                {
                    if (initialSequence[j] < initialSequence[i] && len[j] + 1 > len[i])
                    {
                        len[i] = len[j] + 1;
                        prev[i] = j;
                    }
                }

                if (len[i] > maxLength)
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
            }

            List<int> longestSequence = new List<int>();
            int currentIndex = maxLength - 1;

            while (lastIndex != -1)
            {
                longestSequence.Add(initialSequence[lastIndex]);
                currentIndex--;
                lastIndex = prev[lastIndex];
            }

            longestSequence = longestSequence.OrderBy(x => x).ToList();

            Console.WriteLine(string.Join(' ', longestSequence));
        }
    }
}
