using System;
using System.Linq;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .ToArray();

            Random rand = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                string temp = words[i];

                int position = rand.Next(0, words.Length);
                words[i] = words[position];
                words[position] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
