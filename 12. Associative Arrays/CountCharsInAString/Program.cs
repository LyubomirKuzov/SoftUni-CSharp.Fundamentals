using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            Dictionary<char, int> charsDictionary = new Dictionary<char, int>();

            foreach (var symbol in word)
            {
                if (symbol == ' ')
                {
                    continue;
                }

                if (charsDictionary.ContainsKey(symbol))
                {
                    charsDictionary[symbol]++;
                }

                else
                {
                    charsDictionary.Add(symbol, 1);
                }
            }

            foreach (var symbol in charsDictionary)
            {
                Console.WriteLine($"{symbol.Key} -> {symbol.Value}");
            }
        }
    }
}
