using System;
using System.Collections.Generic;
using System.Linq;

namespace OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Select(x => x.ToLower())
                .ToArray();

            Dictionary<string, int> wordsDictionary = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (wordsDictionary.ContainsKey(word))
                {
                    wordsDictionary[word]++;
                }

                else
                {
                    wordsDictionary.Add(word, 1);
                }
            }

            wordsDictionary = wordsDictionary
                .Where(x => x.Value % 2 != 0)
                .ToDictionary(a => a.Key, b => b.Value);

            Console.WriteLine(string.Join(" ", wordsDictionary.Keys));
        }
    }
}
