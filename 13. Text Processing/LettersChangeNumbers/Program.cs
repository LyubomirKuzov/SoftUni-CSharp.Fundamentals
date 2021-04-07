using System;
using System.Linq;

namespace LettersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            double totalResult = 0;

            foreach (var word in words)
            {
                int number = int.Parse(word.Substring(1, word.Length - 2));

                int indexInAlphabet;

                double result = 0;

                if (char.IsUpper(word[0]))
                {
                    indexInAlphabet = word[0] - 64;
                    result += (double)number / indexInAlphabet;
                }

                else if (char.IsLower(word[0]))
                {
                    indexInAlphabet = word[0] - 96;
                    result += (double)number * indexInAlphabet;
                }

                if (char.IsUpper(word[word.Length - 1]))
                {
                    indexInAlphabet = word[word.Length - 1] - 64;
                    result -= indexInAlphabet;
                }

                else if (char.IsLower(word[word.Length - 1]))
                {
                    indexInAlphabet = word[word.Length - 1] - 96;
                    result += indexInAlphabet;
                }

                totalResult += result;
            }

            Console.WriteLine(totalResult.ToString("f2"));
        }
    }
}
