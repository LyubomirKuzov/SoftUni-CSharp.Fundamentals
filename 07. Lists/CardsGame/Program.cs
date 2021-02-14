using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> secondDeck = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                int firstPlayerCard = firstDeck[0];
                int secondPlayerCard = secondDeck[0];
                firstDeck.RemoveAt(0);
                secondDeck.RemoveAt(0);

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstDeck.Add(firstPlayerCard);
                    firstDeck.Add(secondPlayerCard);
                }

                else if (secondPlayerCard > firstPlayerCard)
                {
                    secondDeck.Add(secondPlayerCard);
                    secondDeck.Add(firstPlayerCard);
                }
            }

            if (firstDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }

            else
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
        }
    }
}
