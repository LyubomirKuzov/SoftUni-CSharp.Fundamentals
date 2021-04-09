using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string emojiPattern = @"([\*]{2}|[\:]{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string digitsPattern = @"\d";

            string text = Console.ReadLine();

            var emojis = Regex.Matches(text, emojiPattern)
                .ToArray();

            var digits = Regex.Matches(text, digitsPattern);

            long coolThreshold = CalculateCoolThreshold(digits);

            var coolEmojis = emojis
                .Where(x => x.Groups["emoji"].Value.Sum(y => y) >= coolThreshold)
                .ToArray();

            Console.WriteLine($"Cool threshold: {coolThreshold}");
            Console.WriteLine($"{emojis.Length} emojis found in the text. The cool ones are:");

            if (coolEmojis.Length > 0)
            {
                foreach (var coolEmoji in coolEmojis)
                {
                    string symbols = coolEmoji.Groups[1].Value;

                    Console.WriteLine($"{symbols}{coolEmoji.Groups["emoji"].Value}{symbols}");
                }
            }
        }

        private static long CalculateCoolThreshold(MatchCollection digits)
        {
            long coolThreshold = 1;

            foreach (Match digit in digits)
            {
                coolThreshold *= int.Parse(digit.Value);
            }

            return coolThreshold;
        }
    }
}
