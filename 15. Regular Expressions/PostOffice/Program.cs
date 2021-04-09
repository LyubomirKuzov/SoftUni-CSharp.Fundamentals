using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PostOffice
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string firstPart = string.Empty;
            string secondPart = string.Empty;
            string thirdPart = string.Empty;

            SplitText(text, ref firstPart, ref secondPart, ref thirdPart);

            Dictionary<char, int> wordsData = FindCapitalLetters(firstPart);
            wordsData = FindLengths(wordsData, secondPart);

            FindAndPrintWords(thirdPart, wordsData);
        }

        static void SplitText(string text, ref string firstPart, ref string secondPart, ref string thirdPart)
        {
            string[] textSplitted = text
                .Split('|')
                .ToArray();

            firstPart = textSplitted[0];
            secondPart = textSplitted[1];
            thirdPart = textSplitted[2];
        }

        static Dictionary<char, int> FindCapitalLetters(string firstPart)
        {
            Dictionary<char, int> wordsData = new Dictionary<char, int>();

            string pattern = @"([#$%*&])(?<capitalLetters>[A-Z]+)\1";

            Match newMatch = Regex.Match(firstPart, pattern);

            string capitalLetters = newMatch.Groups["capitalLetters"].Value;

            for (int i = 0; i < capitalLetters.Length; i++)
            {
                wordsData.Add(capitalLetters[i], 1);
            }

            return wordsData;
        }

        static Dictionary<char, int> FindLengths(Dictionary<char, int> wordsData, string secondPart)
        {
            string pattern = @"(?<capitalLetter>\d{2}):(?<length>\d{2})";

            MatchCollection matches = Regex.Matches(secondPart, pattern);

            for (int i = 0; i < matches.Count; i++)
            {
                int capitalLetterAsInt = int.Parse(matches[i].Groups["capitalLetter"].Value);
                char capitalLetter = Convert.ToChar(capitalLetterAsInt);
                string lengthAsString = matches[i].Groups["length"].Value;

                if (lengthAsString[0] == '0')
                {
                    lengthAsString = lengthAsString.Remove(0, 1);
                }

                int length = int.Parse(lengthAsString);

                if (wordsData.ContainsKey(capitalLetter) && wordsData[capitalLetter] == 1)
                {
                    wordsData[capitalLetter] += length;
                }
            }

            return wordsData;
        }

        static void FindAndPrintWords(string thirdPart, Dictionary<char, int> wordsData)
        {
            string[] words = thirdPart
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var word in wordsData)
            {
                char firstLetter = word.Key;

                if (words.Any(x => x.StartsWith(firstLetter)) && words.Any(x => x.Length == word.Value))
                {
                    string searchedWord = words.FirstOrDefault(x => x.Length == word.Value && x.StartsWith(firstLetter));
                    Console.WriteLine(searchedWord);
                }
            }
        }
    }
}
