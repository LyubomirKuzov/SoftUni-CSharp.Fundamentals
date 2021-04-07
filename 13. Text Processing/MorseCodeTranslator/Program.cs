using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseCodeTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> morseCodeAlphabet = new List<string> { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
            "..-", "...-", ".--", "-..-", "-.--", "--.."};

            string[] hiddenMessageWords = Console.ReadLine()
                .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            StringBuilder sb = new StringBuilder();

            foreach (var word in hiddenMessageWords)
            {
                string[] symbols = word
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                foreach (var symbol in symbols)
                {
                    int index = morseCodeAlphabet.IndexOf(symbol);
                    char letter = (char)(65 + index);
                    sb.Append(letter);
                }

                sb.Append(' ');
            }

            Console.WriteLine(sb.ToString().Trim());
        }
    }
}
