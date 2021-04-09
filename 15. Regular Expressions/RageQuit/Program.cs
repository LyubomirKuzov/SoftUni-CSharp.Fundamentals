using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(?<textToAdd>[\D]+)(?<count>[\d]+)";

            StringBuilder result = new StringBuilder();
            HashSet<char> uniqueSymbols = new HashSet<char>();
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                string text = match.Groups["textToAdd"].Value;
                int count = int.Parse(match.Groups["count"].Value);

                if (count > 0)
                {
                    for (int i = 0; i < text.Length; i++)
                    {
                        uniqueSymbols.Add(char.ToLower(text[i]));
                    }

                    for (int i = 0; i < count; i++)
                    {
                        result.Append(text.ToUpper());
                    }
                }
            }

            Console.WriteLine($"Unique symbols used: {uniqueSymbols.Count}");
            Console.WriteLine(result.ToString().ToUpper());
        }
    }
}
