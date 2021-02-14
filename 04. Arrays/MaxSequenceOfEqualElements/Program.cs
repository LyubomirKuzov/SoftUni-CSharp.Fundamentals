using System;
using System.Linq;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int longestSequenceCount = int.MinValue;
            int longestSequenceDigit = 0;

            int[] numbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currSequenceCount = 1;
                int currSequenceDigit = numbers[i];

                while (i < numbers.Length - 1 && currSequenceDigit == numbers[i + 1])
                {
                    i++;
                    currSequenceCount++;
                }

                if (currSequenceCount > longestSequenceCount)
                {
                    longestSequenceCount = currSequenceCount;
                    longestSequenceDigit = currSequenceDigit;
                }
            }

            for (int i = 0; i < longestSequenceCount; i++)
            {
                Console.Write(longestSequenceDigit + " ");
            }
        }
    }
}
