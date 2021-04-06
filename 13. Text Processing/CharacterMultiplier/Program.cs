using System;
using System.Linq;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            string firstWord = words[0];
            string secondWord = words[1];

            int sum = 0;
            int smallerLength = 0;

            if (firstWord.Length != secondWord.Length)
            {
                smallerLength = Math.Min(firstWord.Length, secondWord.Length);
            }

            else
            {
                smallerLength = firstWord.Length;
            }

            for (int i = 0; i < smallerLength; i++)
            {
                sum += firstWord[i] * secondWord[i];
            }

            firstWord = firstWord.Remove(0, smallerLength);
            secondWord = secondWord.Remove(0, smallerLength);

            if (firstWord.Length > 0)
            {
                sum += CalculateRemainingSum(firstWord);
            }

            else if (secondWord.Length > 0)
            {
                sum += CalculateRemainingSum(secondWord);
            }

            Console.WriteLine(sum);
        }

        private static int CalculateRemainingSum(string word)
        {
            int sum = 0;

            for (int i = 0; i < word.Length; i++)
            {
                sum += word[i];
            }

            return sum;
        }
    }
}
