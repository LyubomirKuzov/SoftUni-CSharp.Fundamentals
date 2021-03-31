using System;
using System.Collections.Generic;

namespace WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonymsDictionary = new Dictionary<string, List<string>>();

            int wordsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (synonymsDictionary.ContainsKey(word))
                {
                    synonymsDictionary[word].Add(synonym);
                }

                else
                {
                    synonymsDictionary.Add(word, new List<string>() { synonym });
                }
            }

            foreach (var word in synonymsDictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
